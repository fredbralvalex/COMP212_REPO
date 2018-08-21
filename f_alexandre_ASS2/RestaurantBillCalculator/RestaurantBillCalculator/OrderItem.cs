using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestaurantBillCalculator.OrderService;

namespace RestaurantBillCalculator
{
    class OrderItem : Product
    {

        private int quantity;
        public int Quantity { get { return quantity; } set {
                if(value > 0) Set(ref quantity, value);} }
        public double TotalPrice { get { return Quantity * Price; } }
        public OrderItem(Product product) : base(product.ID, product.Name, product.Price, product.Category)
        {
            Quantity = 0;
        }
        public void IncrementQuantity()
        {
            Quantity += 1;
        }

    }
}