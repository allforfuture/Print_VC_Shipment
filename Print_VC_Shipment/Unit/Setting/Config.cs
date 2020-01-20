using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Print_VC_Shipment.Unit.Setting
{
    class Config
    {
        static Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private Config() { }

        static public void AddAppSetting(string key, string value)
        {
            _config.AppSettings.Settings.Add(key, value);
            _config.Save();
        }

        static public void SetAppSetting(string key, string value)
        {
            _config.AppSettings.Settings.Remove(key);
            _config.AppSettings.Settings.Add(key, value);
            _config.Save();
        }

        static public string GetAppSetting(string key)
        {
            return _config.AppSettings.Settings[key].Value;
        }

        static public void DelAppSetting(string key)
        {
            _config.AppSettings.Settings.Remove(key);
            _config.Save();
        }
    }
}