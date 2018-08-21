using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frederico_alexandre_Sec002_COMP212_Ex_01
{
    public class Product
    {

        public long ID { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public string Company { get; set; }

        public Product(long iD, string name, double price, string company)
        {
            ID = iD;
            Name = name;
            Price = price;
            Company = company;
        }

        public override string ToString()
        {
            return $"ID: {ID},  Name: {Name}, Price: {Price}, Company: {Company}.\n";
        }
    }
}
