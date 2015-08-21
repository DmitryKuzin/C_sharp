using System;
using ConsoleApplication1.core;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    static class Sort
    {
        public static int best = Configer.ReadConfigToInt("best");
        public static int worst = Configer.ReadConfigToInt("worst");
        public static List<Worker> sort(List<Worker> list)
        {
            list.Sort(new SalaryComparer());
            return list;
        }
        public static List<Worker> theBest(List<Worker> list)
        {
            list.Sort(new SalaryComparer());
            return new List<Worker>(list.Take(best));
        }
        public static List<Worker> theWorst(List<Worker> list)
        {
            list.Sort(new SalaryComparer());
            list.Reverse();
            return new List<Worker>(list.Take(worst));
        }
    }
}