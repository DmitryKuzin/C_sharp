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
        private string line = ".....................................................................";
        private string head = ".id       |name           |lastname       |salary                   .";
        public void PrintTable(List<Worker> list)
        {
            Console.WriteLine(line);
            Console.WriteLine(head);
            Console.WriteLine(line);
            for(int i = 0; i < list.Capacity; i++)
            {
                Worker w = list.First();
                list.Remove(list.First());
                PrintOnePersonTable(w.ID, w.Name, w.LastName, w.Salary);
            }
            Console.ReadLine();
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
            
    }
}
