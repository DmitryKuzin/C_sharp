using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model.exceptions
{
    class IDException:Exception
    {
        public new string Message = "Такой ID уже существует!";

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
