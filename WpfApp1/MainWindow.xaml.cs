using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim().ToLower();

            if (email.Length < 5 || !email.Contains('@') || !email.Contains('.'))
            {
                textBoxEmail.ToolTip = "Email is no correct";
                textBoxEmail.Background = Brushes.IndianRed;
            }
            else if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "No correct length";
                textBoxLogin.Background = Brushes.IndianRed;
            }
            else if (pass.Length > 10)
            {
                passBox.ToolTip = "Password is too short";
                passBox.Background = Brushes.IndianRed;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Passwords do not match";
                passBox_2.Background = Brushes.IndianRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;

                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;

                User user = new User(login, email, pass);

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Succesfull Registration");

                AuthWin authWondow = new AuthWin();
                authWondow.Show();
                Hide();

            }
        }

        private void Button_AuthWin_Click(object sender, RoutedEventArgs e)
        {
            AuthWin authWondow = new AuthWin();
            authWondow.Show();
            Hide(); 
        }

    }
}
