using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model.exceptions
{
    class SalaryException:Exception
    {
        public new string Message = "Отрицательное значение зарплаты!";//намеренно перекрыл поле Message класса Exception

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
        public void PrintMessage(string a)//overload
        {
            Console.WriteLine(Message + " " + a);
        }
    }
}
