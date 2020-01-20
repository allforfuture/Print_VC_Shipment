  declare
    v_rec Record;
    v_idx integer;
    v_len integer;
    v_seq integer;
    v_serial_no text;
    v_ret text;
    
    -- 建立顺序字母表(s_words确定了34进制)
    s_words text := '123456789ABCDEFGHJKLMNPQRSTUVWXYZ';
    -- 进制计算
    base_number INTEGER := length(s_words)+1;
    -- 容量计算(max<1336336)
    volumn_words INTEGER := base_number^4;

    b_year TEXT;
    b_month TEXT;
    b_day TEXT;
    n_date_code TEXT;
    n_datatype_id TEXT;

--BEGIN TRANSACTION ISOLATION LEVEL REPEATABLE READ;  
  BEGIN 
    raise INFO 'INFO RAISE MESSAGE: s_words=% / base_number=% / volumn_words=%', s_words, base_number, volumn_words;

    -- 检查参数
    if a_datatype_id = 'tray' then
        raise INFO 'INFO RAISE MESSAGE: datatype_id=%', a_datatype_id;
        n_datatype_id := 'T';
    elseif a_datatype_id = 'pack' then
        raise INFO 'INFO RAISE MESSAGE: datatype_id=%', a_datatype_id;
        n_datatype_id := 'P';
    elseif a_datatype_id = 'carton' then
        raise INFO 'INFO RAISE MESSAGE: datatype_id=%', a_datatype_id;
        n_datatype_id := 'C';
    elseif a_datatype_id = 'pallet' then
        raise INFO 'INFO RAISE MESSAGE: datatype_id=%', a_datatype_id;
        n_datatype_id := 'L';
    else
        raise WARNING 'WARNING RAISE MESSAGE: DATATYPE_ID ERROR / datatype_id=%', a_datatype_id;
        return 'ERRORTYPE';
    end if;

    -- 日期转换
    b_year := substring(a_shift_date, 4, 1);
    b_month := substring(a_shift_date, 5, 2);
    b_day := substring(a_shift_date, 7, 2);
    --raise INFO 'INFO RAISE MESSAGE: b_year=%', b_year;
    --raise INFO 'INFO RAISE MESSAGE: b_month=%', b_month;
    --raise INFO 'INFO RAISE MESSAGE: b_day=%', b_day;
    CASE b_month
        WHEN '01', '02', '03', '04', '05', '06', '07', '08', '09' THEN 
	    n_date_code := b_year || SUBSTRING(b_month, 2, 1) || b_day;
        WHEN '10' THEN 
        	n_date_code := b_year || 'A' || b_day;
        WHEN '11' THEN 
	    n_date_code := b_year || 'B' || b_day;
        WHEN '12' THEN 
	    n_date_code := b_year || 'C' || b_day;
    ELSE 
        raise WARNING 'WARNING RAISE MESSAGE: TRANSFORM MONTH FAIL / b_month=%', b_month;
        return 'ERRORDATE';
    END CASE;

    -- 构建新编码
    select * into v_rec from t_apply_no 
    where site_cd = a_site_cd 
    AND material_cd = a_material_cd 
    and shift_date = a_shift_date 
    AND datatype_id = a_datatype_id;  
    --raise INFO 'INFO RAISE MESSAGE: v_rec=%', v_rec;

    if v_rec is null then
	-- 新建
	v_seq := 1;
	v_serial_no := '0001';
        -- 更新预约管理表
        insert into t_apply_no(site_cd, material_cd, shift_date, datatype_id, apply_seq, apply_lasttime) 
        values (a_site_cd, a_material_cd, a_shift_date, a_datatype_id, v_seq, now());
    else
        -- 累加
        v_seq := v_rec.apply_seq + 1;
        -- 检查序号是否溢出
        if v_seq >= volumn_words then
            raise WARNING 'WARNING RAISE MESSAGE: SEQUENCE OVERFLOW / v_seq=%', v_seq;
            return 'OVERFLOW';
        end if;
        
        -- 计算流水号
        v_serial_no := '';
        while v_seq >= base_number loop
            v_idx := v_seq % base_number;
            v_seq := v_seq / base_number;

            if v_idx = 0 then
                v_serial_no := '0' || v_serial_no;
            else
                v_serial_no := substring(s_words, v_idx, 1) || v_serial_no;
            end if;
        end loop;
        v_serial_no := substring(s_words, v_seq, 1) || v_serial_no;
        -- 补零，v_serial_no最少长度1，要满足4位，则需补足3个零
        v_len := 4 - length(v_serial_no);
        raise DEBUG 'DEBUG RAISE MESSAGE: v_len=%', v_len;
        -- 从'000'字符串当中截取需要的零，补给v_serial_no
        v_serial_no := substring('000', 1, v_len) || v_serial_no;

        -- 更新预约管理表
        update t_apply_no 
        set apply_seq = v_rec.apply_seq + 1, apply_lasttime = now() 
        where site_cd = a_site_cd 
        AND material_cd = a_material_cd 
        and shift_date = a_shift_date 
        AND datatype_id = a_datatype_id;        
    end if;

    -- 合成号码
    v_ret := a_site_cd || '_' || a_material_cd || '_' || n_date_code || '_' || n_datatype_id || '_' || v_serial_no;
    -- 操作记录
    insert into t_pnt_manager (pkg_id, pkg_type, act, pkg_date, pkg_user, status, remark) values (v_ret, a_datatype_id, 'reserve', now(), a_user, 0, '预约');
    -- 返回结果
    return v_ret;
    
  END;
