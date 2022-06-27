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
    /// Логика взаимодействия для maket.xaml
    /// </summary>
    public partial class maket : Page
    {
        public maket(Employer employer)
        {
            InitializeComponent();

            if(employer.position == 2)
            {
                Client.Visibility = Visibility.Hidden;
                Catalog.Visibility = Visibility.Hidden;
                Order.Visibility = Visibility.Hidden;
                za.Visibility = Visibility.Hidden;
            }
            frame.NavigationService.Navigate(new MainPage());
        }

        private void GoMaster(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MainPage());

        }

        private void GoClient(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new ClientPage());

        }

        private void GoListToys(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new ListToys());
        }

        private void GoOrder(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new OrderPage());
        }

        private void GoMaterial(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MaterialPage());
        }

        private void GoFormCreateToy(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new FormCreateToy());
        }

        private void GoFormMaster(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MasterFormPage());
        }
    }
}
