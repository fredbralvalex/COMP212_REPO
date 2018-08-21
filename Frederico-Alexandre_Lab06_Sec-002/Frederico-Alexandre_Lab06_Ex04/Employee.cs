using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex04
{
    class Employee : IComparable
    {
        string Name { get; set; }
        double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name},  Salary: {Salary}.";
        }

        public int CompareTo(object emp)
        {
            return this.Salary.CompareTo(((Employee)emp).Salary);
        }
    }
}
