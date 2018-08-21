using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    class Item
    {
        public Item(int id, string description, double price, int quantity)
        {
            ID = id;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public int ID { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        //public override string ToString()
        //{
        //    return "ID: " + ID + " Description: " + Description + " Price: " + Price + " Quantity: " + Quantity;
        //}
        public override string ToString() => $"ID: {ID}, Description: {Description}, Price: {Price}, Quantity:{Quantity}";
    }
}
