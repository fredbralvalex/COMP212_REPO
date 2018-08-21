using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class Dessert : Product
    {
        public Dessert(int id, string name, double price) : base(id, name, price, Category.Dessert)
        {

        }

    }
}
