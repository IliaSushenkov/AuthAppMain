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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AuthWin.xaml
    /// </summary>
    public partial class AuthWin : Window
    {
        public AuthWin()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "No correct length";
                textBoxLogin.Background = Brushes.IndianRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Password is too short";
                passBox.Background = Brushes.IndianRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                User authUser = null;
                using(AppContext context = new AppContext())
                {
                    authUser = context.Users.Where(b => b.Login == login &&
                    b.Email == pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    MessageBox.Show("Succesfull Log In");
                    UserPageWin userPageWin = new UserPageWin();
                    userPageWin.Show();
                    Hide();
                }
                else
                    MessageBox.Show("User not found");
            }
        }

        private void Button_To_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
