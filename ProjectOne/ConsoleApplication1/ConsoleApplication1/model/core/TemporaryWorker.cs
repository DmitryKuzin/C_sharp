using ConsoleApplication1.core;
using ConsoleApplication1.model.exceptions;
using System;


namespace ConsoleApplication1.model
{
    [Serializable]
    class TemporaryWorker : Worker
    {
        public TemporaryWorker() { }
        public TemporaryWorker(string name, string lastName, int id, double perHourRate)
        {
            setSalary(perHourRate);
            resetName(name, lastName, id);
        }

        public override void setSalary(ValueType perHourRate)
        {
            double index = Configer.ReadConfigToDouble("index");
            double hours = Configer.ReadConfigToDouble("hours");
            Salary = (double)perHourRate * hours * index;
        }
    }
}
