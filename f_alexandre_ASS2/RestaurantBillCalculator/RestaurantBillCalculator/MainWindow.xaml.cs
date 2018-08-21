using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantBillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Product> productList = new ObservableCollection<Product>();
        private OrderService orderService = new OrderService();

        IEnumerable<OrderItem> Orders => orderService.orders;
        //double total => orderService.Total;
        public MainWindow()
        {
            InitializeComponent();
            storeProducts();
            buildComboBoxItems();
            OrderDataGrid.ItemsSource = orderService.orders;
            tbTotal.DataContext = orderService;
            tbSubTotal.DataContext = orderService;
            tbTax.DataContext = orderService;
        }

        private void storeProducts()
        {
            productList.Add(new Beverage(1,"Soda", 1.95));
            productList.Add(new Beverage(2, "Tea", 1.50));
            productList.Add(new Beverage(3, "Coffee", 1.25));
            productList.Add(new Beverage(4, "Mineral Water", 2.95));
            productList.Add(new Beverage(5, "Juice", 2.50));
            productList.Add(new Beverage(6, "Milk", 1.50));

            
            productList.Add(new Appetizer(7, "Buffalo Wings", 5.95));
            productList.Add(new Appetizer(8, "Buffalo Fingers", 6.95));
            productList.Add(new Appetizer(9, "Potato Skin", 8.95));
            productList.Add(new Appetizer(10, "Nachos", 8.95));
            productList.Add(new Appetizer(11, "Mushroom Caps", 10.95));
            productList.Add(new Appetizer(12, "Shrimp Cocktail", 12.95));
            productList.Add(new Appetizer(13, "Chips and Salsa", 6.95));

            productList.Add(new MainCourse(14, "Seafood Alfredo", 15.95));
            productList.Add(new MainCourse(15, "Chicken Alfredo", 14.95));
            productList.Add(new MainCourse(16, "Chicken Picatta", 13.95));
            productList.Add(new MainCourse(17, "Turkey Club", 11.95));
            productList.Add(new MainCourse(18, "Lobster Pie", 19.95));
            productList.Add(new MainCourse(19, "Prime Rib", 20.95));
            productList.Add(new MainCourse(20, "Shrimp Scamp", 18.95));
            productList.Add(new MainCourse(21, "Turkey Dinner", 13.95));
            productList.Add(new MainCourse(22, "Stuffed Chicken", 14.95));

            productList.Add(new Dessert(23, "Apple Pie", 5.95));
            productList.Add(new Dessert(24, "Sundae", 3.95));
            productList.Add(new Dessert(25, "Carrot Cake", 5.95));
            productList.Add(new Dessert(26, "Mud Pie", 4.95));
            productList.Add(new Dessert(27, "Apple Crisp", 5.95));

        }

        private void buildComboBoxItems()
        {
            ObservableCollection<Product> list = new ObservableCollection<Product>();
            //Beverage
            foreach (Product product in productList)
            {
                if (product is Beverage)
                {
                    list.Add(product);
                }
            }
            cbBeverage.ItemsSource = list;

            list = new ObservableCollection<Product>();
            //Appetizer
            foreach (Product product in productList)
            {
                if (product is Appetizer)
                {
                    list.Add(product);
                }
            }
            cbAppetizer.ItemsSource = list;

            list = new ObservableCollection<Product>();
            //Main Course
            foreach (Product product in productList)
            {
                if (product is MainCourse)
                {
                    list.Add(product);
                }
            }
            cbMainCourse.ItemsSource = list;

            list = new ObservableCollection<Product>();
            //Dessert
            foreach (Product product in productList)
            {
                if (product is Dessert)
                {
                    list.Add(product);
                }
            }
            cbDessert.ItemsSource = list;
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex >= 0)
            {
                Product product = (sender as ComboBox).SelectedValue as Product;
                orderService.AddOrderItem(new OrderItem(product));
                ((ComboBox)sender).SelectedIndex = -1;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            orderService.RefreshOrders();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            List<OrderItem> orders = OrderDataGrid.SelectedItems.Cast<OrderItem>().ToList();
            if (orders != null)
            {
                foreach (OrderItem  order in orders)
                {
                    orderService.RemoveOrderItem(order);
                }

            }
        }
    }
}
