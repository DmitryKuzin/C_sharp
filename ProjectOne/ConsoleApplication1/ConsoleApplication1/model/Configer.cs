using ConsoleApplication1.model.exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    static class Configer
    {
        public static double ReadConfigToDouble(string key)
        {
            isConfigHasKey(key); 
            return Double.Parse(ConfigurationManager.AppSettings[key]);
        }
        public static int ReadConfigToInt(string key)
        {
            isConfigHasKey(key);
            return Int32.Parse(ConfigurationManager.AppSettings[key]);
        }
        public static string ReadConfigToString(string key)
        {
            isConfigHasKey(key);
            return ConfigurationManager.AppSettings[key];
        }
        public static void WriteToConfig(string key,string value)
        {
            ConfigurationManager.AppSettings.Set(key, value);
        }
        private static void isConfigHasKey(string key)
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                throw new ConfigException();
            }
        }

        //private static void doConfigBussines()
       // {
            // открываем текущий конфиг специальным обьектом
        //    System.Configuration.Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // добавляем позицию в раздел AppSettings
         //   currentConfig.AppSettings.Settings.Add("index", "20.8");
         //   currentConfig.AppSettings.Settings.Add("hours", "8");
            //сохраняем
         //   currentConfig.Save(ConfigurationSaveMode.Full);
            //принудительно перезагружаем соотвествующую секцию
        //    ConfigurationManager.RefreshSection("appSettings");
       // }
    }
}
