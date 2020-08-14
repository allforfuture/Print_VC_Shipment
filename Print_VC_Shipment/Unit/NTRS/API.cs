using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Print_VC_Shipment.Unit.NTRS
{
    class API
    {
        static string assy_cd = System.Configuration.ConfigurationManager.AppSettings["assy_cd"];
        static string work_mode = System.Configuration.ConfigurationManager.AppSettings["work_mode"];
        static string url = System.Configuration.ConfigurationManager.AppSettings["API"];
        public static string SN_Judge(string SN, out string detail)
        {
            detail = "";
            //POST参数param
            //assy_cd=COVER&serial_cd=GH98503102ZKPK627
            string POSTparam = "assy_cd=" + assy_cd + "&serial_cd=" + SN;
            if (work_mode != "N/A")
                POSTparam += "&work_mode=" + work_mode;
            // param转换
            byte[] data = Encoding.ASCII.GetBytes(POSTparam);

            ServicePointManager.Expect100Continue = false; //HTTP错误（417）对应

            //创建请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            //POST写入
            try
            {
                using (Stream reqStream = request.GetRequestStream())
                    reqStream.Write(data, 0, data.Length);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Environment.Exit(0); }

            //取得响应
            WebResponse response = request.GetResponse();

            //读取结果
            string APIstr = "";
            using (Stream resStream = response.GetResponseStream())
            using (var reader = new StreamReader(resStream, Encoding.GetEncoding("UTF-8")))
                APIstr = reader.ReadToEnd();
            
            if (APIstr == "{}")
            {
                MessageBox.Show("接收到空值。\r\n请检查配置文件中的assy_cd与API的值是否正确。\r\n将会关闭程序。", "API接收", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            JObject JO = null;
            try { JO = JObject.Parse(APIstr); }
            catch { MessageBox.Show("返回的Json:\r\n" + APIstr, "解析Json失败", MessageBoxButtons.OK, MessageBoxIcon.Error); Environment.Exit(0); }

            string result = JO["total_judge"].ToString();

            #region detail值写入
            try
            {
                JObject JO_phase2 = JObject.Parse(JO["comments"]["phase2_detail"].ToString());
                foreach (var var in JO_phase2)
                {
                    detail += string.Format("phase2,{0}:{1}\r\n", var.Key, var.Value);
                }
            }
            catch { }
            try
            {
                JObject JO_phase3a = JObject.Parse(JO["comments"]["phase3a_detail"].ToString());
                foreach (var var in JO_phase3a)
                {
                    detail += string.Format("phase3a,{0}:{1}\r\n", var.Key, var.Value);
                }
            }
            catch { }
            try
            {
                JObject JO_phase3b = JObject.Parse(JO["comments"]["phase3b_detail"].ToString());
                foreach (var var in JO_phase3b)
                {
                    detail += string.Format("phase3b,{0}:{1}\r\n", var.Key, var.Value);
                }
            }
            catch { }
            try
            {
                JObject JO_phase3a_fail = JObject.Parse(JO["comments"]["phase3a_fail_count"].ToString());
                foreach (var var in JO_phase3a_fail)
                {
                    detail += string.Format("phase3a_fail,{0}:{1}\r\n", var.Key, var.Value);
                }
            }
            catch { }
            #endregion
            return result;
        }
    }
}
