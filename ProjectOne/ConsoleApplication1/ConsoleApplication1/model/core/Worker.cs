using System;


namespace ConsoleApplication1.core
{
    [Serializable]
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
