using BaseballLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace ManageBaseballPlayer
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly System.Globalization.NumberFormatInfo NumberFormatEnUS = 
            System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat;
        bool edit = false;

        PlayerController playerController = new PlayerController();
        public MainWindow()
        {
            InitializeComponent();
            playerController = new PlayerController();            

            dgPlayers.ItemsSource = playerController.Players;
        }

        private void BtLastNameSearch_Click(object sender, RoutedEventArgs e)
        {
            playerController.QueryPlayers(tbLastName.Text);
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player();
            if (CheckValidString(tbFormFirstName.Text) && CheckValidString(tbFormLastName.Text))
            {
                player.FirstName = tbFormFirstName.Text;
                player.LastName = tbFormLastName.Text;
                player.BattingAverage = CovertValidDecimal(tbFormBattingAve.Text);
                Player plyer = dgPlayers.SelectedItem as Player;
                if (edit)
                {
                    player.PlayerID = plyer.PlayerID;
                    playerController.QueryUpdatePlayer(player);
                } else
                {
                    playerController.QueryInsertPlayer(player);
                }                
                BtNew_Click(sender, e);
            }
        }

        private bool CheckValidString(string str)
        {
            return str != null && str.Length > 0;
        }

        private Decimal CovertValidDecimal(string str)
        {
            if (CheckValidString(str))
            {           
                return Convert.ToDecimal(tbFormBattingAve.Text, NumberFormatEnUS);
            }
            return 0;
        }

        private void BtNew_Click(object sender, RoutedEventArgs e)
        {
            edit = false;
            tbFormFirstName.Text = "";
            tbFormLastName.Text = "";
            tbFormBattingAve.Text = "";
        }

        private void DgPlayerEditPlayer(object sender, MouseButtonEventArgs e)
        {
            SelectionDataGrid(sender);
        }

        private void DgPlayerEditPlayer(object sender, SelectionChangedEventArgs e)
        {
            SelectionDataGrid(sender);
        }
        private void SelectionDataGrid(object sender)
        {
            DataGrid dgrid = sender as DataGrid;
            Player player = dgrid.SelectedItem as Player;
            if (player != null)
            {
                edit = true;
                tbFormFirstName.Text = player.FirstName;
                tbFormLastName.Text = player.LastName;
                tbFormBattingAve.Text = Convert.ToString(player.BattingAverage, NumberFormatEnUS);
            }
        }
    }
}
