using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class MainCourse : Product
    {
        public MainCourse(int id, string name, double price) : base(id, name, price, Category.MainCourse)
        {

        }
    }
}
