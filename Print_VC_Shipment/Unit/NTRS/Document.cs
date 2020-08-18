using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Configuration;

namespace Print_VC_Shipment.Unit.NTRS
{
    class Document
    {
        public static List<string> pathList = new List<string>()
        {
            AppDomain.CurrentDomain.BaseDirectory + "log\\",
            ConfigurationManager.AppSettings["path"]
        };

        public static void CreateDocument()
        {
            foreach (string path in pathList)
            {
                Directory.CreateDirectory(path);
            }
        }
    }

    class Log : Document
    {
        public static void WriteLog(string SN, string detail, string judge)
        {
            string path = Document.pathList[0] + "log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                string str = DateTime.Now.ToString("yyyy/MM/dd,HH:mm:ss,")
                    + SN + ","
                    + detail.Replace("\r\n", "$").Replace(",", "/") + ","
                    + judge;
                file.WriteLine(str);// 直接追加文件末尾，换行
            }
        }

        public static void WriteError(string SN)
        {
            string path = Document.pathList[0] + "log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy/MM/dd,HH:mm:ss,@") + SN);// 直接追加文件末尾，换行 
            }
        }
    }

    class Pqm : Document
    {
        public static string type = ConfigurationManager.AppSettings["type"];
        static string factory = ConfigurationManager.AppSettings["factory"];
        static string building = ConfigurationManager.AppSettings["building"];
        public static string line = ConfigurationManager.AppSettings["line"];
        public static string process = ConfigurationManager.AppSettings["process"];
        static string inspect = ConfigurationManager.AppSettings["inspect"];

        public static void WriteCSV(string SN,string checkItem,string checkTotal)
        {
            string fileName = type + factory + building + line + process + DateTime.Now.ToString("yyyyMMddHHmmss") + SN;
            string path = Path.Combine(Document.pathList[1], fileName + ".csv");
            using (StreamWriter file = new StreamWriter(path, true))
            {
                string[] csvStr = new string[] { type, factory, building, line, process, SN, "", "","", DateTime.Now.ToString("yy,MM,dd,HH,mm,ss"), "1", inspect,
                            "N/A","N/A","0.0", checkItem, checkTotal, "1", "JIG",
                            type + line.Remove(0, 1) + process.Substring(0,1) + DateTime.Now.ToString("yyMMddHHmmss").Remove(0, 1) };

                string str = String.Join(",", csvStr);

                file.WriteLine(str);// 直接追加文件末尾，换行 
            }
        }
    }
}
