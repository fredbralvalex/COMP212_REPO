using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    class OrderService :BindableBase
    {
        private const double TAX = 0.13;
        public double Tax { get { return TAX; } }
        private ObservableCollection<OrderItem> _orders = new ObservableCollection<OrderItem>();
        private double total = 0;
        public double Total
        {
            get
            {               
                return total;
            }

            set
            {
                Set(ref total, value);
            }

        }

        private double subtotal = 0;
        public double SubTotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                Set(ref subtotal, value);
            }

        }

        public void RefreshOrders()
        {
            _orders.Clear();
            var sampleOrdersService = new HistoricalOrderService();
            var orders = sampleOrdersService.GetHistoricalOrders();
            foreach (var order in orders)
            {
                _orders.Add(order);
            }
            UpdateTotal();
        }

        public OrderItem GetOrderItem(int orderId) =>
            _orders.Where(b => b.ID == orderId).SingleOrDefault();

        public void AddOrderItem(OrderItem order) {
            OrderItem product = GetOrderItem(order.ID);            

            if (product == null)
            {
                //setting a delegate to use as event
                order.PropertyChanged += UpdateTotal;
                _orders.Add(order);
                //call the event to
                order.IncrementQuantity();
            } else
            {
                product.IncrementQuantity();
                //setting a delegate to use as event
            }
        }

        private void UpdateTotal(object sender, PropertyChangedEventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            double _total = 0;
            foreach (var order in orders)
            {
                _total += order.TotalPrice;
            }
            Total = _total;
            SubTotal = Total * (1 + TAX);
        }
        public void RemoveOrderItem(OrderItem order)
        {
            OrderItem product = GetOrderItem(order.ID);
            if (product != null)            
            {
                _orders.Remove(product);
            }
            UpdateTotal();
        }

        public IEnumerable<OrderItem> orders => _orders;

    }
}
