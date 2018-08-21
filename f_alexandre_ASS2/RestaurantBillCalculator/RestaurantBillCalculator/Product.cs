using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{

    public enum Category { Beverage, Appetizer, MainCourse, Dessert};
    class Product : BindableBase
    {

        public Product(int id, string name, double price, Category category)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public string CategoryName { get { return Regex.Replace(Category.ToString(), "([a-z])([A-Z])", "$1 $2"); } }

    }
}
