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
        public maket()
        {
            InitializeComponent();
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
    }
}
