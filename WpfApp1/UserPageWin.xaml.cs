using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для UserPageWin.xaml
    /// </summary>
    public partial class UserPageWin : Window
    {
        AppContextForClient db;
        public UserPageWin()
        {
            InitializeComponent();

            db = new AppContextForClient();
            List<Client> clients = db.Clients.ToList();
            listOfUsers.ItemsSource = clients;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
            Hide();
        }

        private void Button_Del_Click(object sender, RoutedEventArgs e)
        {
            Client client = listOfUsers.SelectedItem as Client;
            if (client is null) return;

            db.Clients.Remove(client);
            db.SaveChanges();
            listOfUsers.Items.Refresh();
        }
    }
}
