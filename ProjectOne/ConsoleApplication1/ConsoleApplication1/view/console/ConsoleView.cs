using ConsoleApplication1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.view.console
{
    class ConsoleView
    {
        public void printNameOfProgram()
        {
            for(int i = 0; i < 5; i++)
            {
                Print("");
            }
            Print("                        Console App ");
            Print("");
        }
        public void Stop()
        {
            Console.ReadLine();
        }
        public string Hear()
        {
            return Console.ReadLine();
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        private string line = ".....................................................................";
        private string head = ".id       |name           |lastname       |salary                   .";
        public void PrintTable(List<Worker> list)
        {
            Console.WriteLine(line);
            Console.WriteLine(head);
            Console.WriteLine(line);
            foreach(var w in list)
            {
                PrintOnePersonTable(w.ID, w.Name, w.LastName, w.Salary);
            }
        }
        public void PrintOnePersonTable(int id, string name, string lastName, double salary)
        {
            
            Console.WriteLine("." + format(9, id) + "|" + format(15, name) +"|"+ format(15, lastName) + "|" + format(10, (int)salary) + "rub."); 
            
        }
        private string format(int indent,int value)
         {
            
            string b=value.ToString();
            for(int i=0;i< indent-valueLength(value); i++)
            {
                b += " ";
            }
            return b;
        }
        private string format(int indent,string str)
        {
            string b = str;
            for (int i = 0; i < indent-str.Length; i++)
            {
                b += " ";
            }
            return b;
        }
        private int valueLength(int value)
        {
            int count = 0;
            if (value == 0)
            {
                return 1;
            }
            while (value > 0)
            {
                value /= 10;
                count++;
            }
            return count;
        }
        public void GetHelp()
        {
            Print("To get Help write -help");
            Print("To show table write -getTable ");
           // Print("To change one worker properties write -change");
            Print("To create new workers write -in");
            //Print("To delete one worker write -out");
            Print("To delete all workers write -collapse");
            Print("To get top write -getTop");
            Print("To save table in file write -save");
            Print("To read from file write -read");
            Print("To change properties of program write -changeProperties");
        }
    }
}
