using SaleLibrary;
using System;
using System.Collections.Generic;
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

namespace ManageSalesWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SalesManagementController controller = new SalesManagementController();
        public MainWindow()
        {
            InitializeComponent();
            SalesDataGrid.ItemsSource = controller.QuerySales();
            CbProduct.ItemsSource = controller.Products;
        }

        private void BtSearch_Click(object sender, RoutedEventArgs e)
        {
            string employeeId = TbEmployeeID.Text;            
            SalesDataGrid.ItemsSource = controller.QuerySales(employeeId);
        }

        private void BtSale_Click(object sender, RoutedEventArgs e)
        {
            product p = CbProduct.SelectedItem as product;
            string employeeId = TbEmployeeID.Text;
            //add some validation 
            int quantity = Convert.ToInt32(TbQuantity.Text);

            controller.InsertSale(p, quantity, employeeId);
        }
    }
}
