using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        AppContextForClient db;

        public AddClient()
        {
            InitializeComponent();
            db = new AppContextForClient();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string age = textBoxAge.Text.Trim();
            string city = textBoxCity.Text.Trim();
            string salary = textBoxSalary.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (name.Length < 5)
            {
                textBoxName.ToolTip = "Name is too short!";
                textBoxName.Background = Brushes.IndianRed;
            }
            else if (salary.Length < 3)
            {
                textBoxSalary.ToolTip = "Salary is too small";
                textBoxSalary.Background = Brushes.IndianRed;
            }
            else if (email.Length < 5 || !email.Contains('@') || !email.Contains('.'))
            {
                textBoxEmail.ToolTip = "Email is no correct";
                textBoxEmail.Background = Brushes.IndianRed;
            }
            else
            {
                textBoxName.ToolTip = "";
                textBoxName.Background = Brushes.Transparent;

                textBoxAge.ToolTip = "";
                textBoxAge.Background = Brushes.Transparent;

                textBoxCity.ToolTip = "";
                textBoxCity.Background = Brushes.Transparent;

                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                textBoxSalary.ToolTip = "";
                textBoxSalary.Background = Brushes.Transparent;

                Client client = new Client(name, age, city, salary, email);

                db.Clients.Add(client);
                db.SaveChanges();

                MessageBox.Show("New client added!");

                UserPageWin userPageWin = new UserPageWin();
                userPageWin.Show();
                Hide();
            }
        }
    }
}
