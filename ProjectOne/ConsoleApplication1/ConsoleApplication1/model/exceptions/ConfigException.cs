using System;
using ConsoleApplication1.view.console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model.exceptions
{
    class ConfigException:Exception
    {
        public new string Message = "Поврежденный файл app.config!";

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
