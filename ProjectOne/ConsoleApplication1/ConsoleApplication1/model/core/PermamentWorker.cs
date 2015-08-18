using ConsoleApplication1.core;
using ConsoleApplication1.model.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    class PermamentWorker:Worker
    {
        public PermamentWorker() { }
        public PermamentWorker(string name, string lastName, int id, double salaryValue)
        {
            setSalary(salaryValue);
            resetName(name, lastName, id);
        }
        public override void setSalary(ValueType salary)
        {
            Salary = (double)salary;
        }
    }
}
