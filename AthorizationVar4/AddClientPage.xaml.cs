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

namespace AthorizationVar4
{
    /// <summary>
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        var4Entities1 context;
        Client c;
        public AddClientPage(var4Entities1 cont, Client client)
        {
            InitializeComponent();
            context = cont;
            c = client;
            fioBox.Text = c.name;
            passportBox.Text = c.passport;
            
        }

        private void AddNewClient(object sender, RoutedEventArgs e)
        {
            context.Client.Find(c.num).name = fioBox.Text;
            context.Client.Find(c.num).passport = passportBox.Text;

            context.SaveChanges();

            NavigationService.Navigate(new ClientPage());
        }
    }
}
