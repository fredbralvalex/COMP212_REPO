using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex03
{
    public class Student
    {
        private int ID { get; set; }
        private string Name { get; set; }

        public Student(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID},  Name: {Name}.";
        }
    }
}
