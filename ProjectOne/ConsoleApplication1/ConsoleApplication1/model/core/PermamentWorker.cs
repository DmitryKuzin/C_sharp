using ConsoleApplication1.core;
using ConsoleApplication1.model.exceptions;
using System;

namespace ConsoleApplication1.model
{
    [Serializable]
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
