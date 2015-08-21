using ConsoleApplication1.core;
using ConsoleApplication1.model.Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    class SalaryComparer : IComparer<Worker>
    {
       
        public int Compare(Worker x, Worker y)
        {
            if (x.Salary < y.Salary)
            {
                return 1;
            }
            else if (x.Salary > y.Salary)
            {
                return -1;
            }
            else
            {
                return new NameComparer().Compare(x, y);
            }
        }
    }
}
