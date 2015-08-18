using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.core
{
    abstract class Worker
    {
        public string Name="Agent";
        public string LastName="Smith";
        public double Salary=0;
        public int ID=0;
        abstract public void setSalary(ValueType a);
        public void resetName(string name, string lastName,int id)
        {
            Name = name;
            LastName = lastName;
            ID = id;
        }
    }
}
