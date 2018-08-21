using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class Appetizer : Product
    {
        public Appetizer(int id, string name, double price) : base(id, name, price, Category.Appetizer)
        {

        }

    }
}
