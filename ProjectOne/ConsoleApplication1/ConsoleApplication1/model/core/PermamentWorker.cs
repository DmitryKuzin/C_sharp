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
           // if (sal < 0)
            //    throw new SalaryException();
            
        }
        public override void changeSalary(ValueType salaryValue)
        {
            Salary = (double)salaryValue;
            //if (Salary < 0)
              //  throw new SalaryException();
        }

        public override void resetName(string name, string lastName, int id)
        {
            Name = name;
            LastName = lastName;
            ID = id;
        }
    }
}
