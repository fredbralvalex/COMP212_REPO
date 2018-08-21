using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace LoginUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        public static DependencyProperty UserNameProperty =
            DependencyProperty.Register(nameof(UserName), typeof(string),
                typeof(LoginUserControl), new PropertyMetadata(""));

        public SecureString UserPassword
        {
            get { return (SecureString)GetValue(UserPasswordProperty); }
            set { SetValue(UserPasswordProperty, value); }
        }

        public static DependencyProperty UserPasswordProperty =
            DependencyProperty.Register(nameof(UserPassword), typeof(SecureString),
                typeof(LoginUserControl), new PropertyMetadata(new SecureString()));

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            string pw = (sender as PasswordBox).Password;
            var secure = new SecureString();
            foreach (char c in pw)
            {
                secure.AppendChar(c);
            }

            UserPassword = secure;
        }
    }
}
