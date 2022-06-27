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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        var4Entities1 context;
        public ClientPage()
        {
            InitializeComponent();
            context = new var4Entities1();
            clientTable.ItemsSource = context.Client.ToList();
        }

        private void EditMaster(object sender, RoutedEventArgs e)
        {
            Client client = clientTable.SelectedItem as Client;
            NavigationService.Navigate(new AddClientPage(context, client));
        }

        private void SearchByFio(object sender, TextChangedEventArgs e)
        {
            var list = context.Client.ToList();
            if (!string.IsNullOrWhiteSpace(fioBox.Text))
            {
                list = list.Where(x => x.name.ToLower().Contains(fioBox.Text.ToLower())).ToList();
            }
            clientTable.ItemsSource = list;
        }
    }
}
