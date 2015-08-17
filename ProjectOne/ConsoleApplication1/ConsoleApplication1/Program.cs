using ConsoleApplication1.core;
using ConsoleApplication1.model;
using ConsoleApplication1.model.exceptions;
using ConsoleApplication1.view.console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker Pete=null;
            //Worker Michael=null;
            //Pete = new TemporaryWorker("Pete", "Orange", 1, 150);//почасовая оплата
            //Michael = new PermamentWorker();//оклад
            //Console.WriteLine(Pete.Name + " " + Pete.LastName + " " + Pete.ID + " "+Pete.Salary); 
            //Console.WriteLine(Michael.Name + " " + Michael.LastName + " " + Michael.ID + " " + Michael.Salary);
            //Console.Read();
            ConsoleView cv = new ConsoleView();
            List<Worker> list = new List<Worker>();
            Worker a = new PermamentWorker("John", "Garret", 1, 22300);
            Worker b = new TemporaryWorker("Pete", "Jordan", 2, 550);
            Worker c = new PermamentWorker("Dima", "Kuzin", 3, 999999);
            Worker d = new TemporaryWorker();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            cv.PrintTable(list);

        }
    }
}
