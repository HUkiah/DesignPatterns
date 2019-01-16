using iteratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace iteratorPattern.Impl
{
    public abstract class Employee
    {
        private string Name;
        private int Salary;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetSalary()
        {
            return Salary;
        }
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
        public abstract void accept(IVisitor visitor);
    }
}
