using ConsoleApplication1.core;
using ConsoleApplication1.model.exceptions;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    class TemporaryWorker:Worker
    {
        public TemporaryWorker()
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("index"))
            {
                doConfigBussines();
            }
        }

        public TemporaryWorker(string name,string lastName,int id,double perHourRate)
        {
            
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("index"))
            {
                doConfigBussines();  
            }
            setSalary(perHourRate);
            resetName(name, lastName, id);
        }
        
        public override void setSalary(ValueType perHourRate)
        {
            double index = Double.Parse(ConfigurationManager.AppSettings["index"]);
            double hours = Double.Parse(ConfigurationManager.AppSettings["hours"]);
            Salary = (double)perHourRate * hours*index;
        }
        private static void doConfigBussines()
        {
            // открываем текущий конфиг специальным обьектом
            System.Configuration.Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // добавляем позицию в раздел AppSettings
            currentConfig.AppSettings.Settings.Add("index", "20.8");
            currentConfig.AppSettings.Settings.Add("hours", "8");
            //сохраняем
            currentConfig.Save(ConfigurationSaveMode.Full);
            //принудительно перезагружаем соотвествующую секцию
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
