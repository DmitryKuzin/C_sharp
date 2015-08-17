using ConsoleApplication1.core;
using ConsoleApplication1.model.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    class TemporaryWorker:Worker
    {
        public TemporaryWorker() { }
        public TemporaryWorker(string name,string lastName,int id,double perHourRate)
        {
            setSalary(perHourRate);
            resetName(name, lastName, id);
        }
        
        public override void setSalary(ValueType perHourRate)
        {
            Salary = (double)perHourRate * 20.8 * 8.0;
          //  if (Salary < 0)
          //      throw new SalaryException();
            

        }
        public override void changeSalary(ValueType perHourRate)
        {
            Salary = (double)perHourRate * 20.8 * 8.0;
         //   if (Salary < 0)
          //      throw new SalaryException();
        }

        public override void resetName(string name, string lastName, int id)
        {
            Name = name;
            LastName = lastName;
            ID = id;
        }
    }
}
