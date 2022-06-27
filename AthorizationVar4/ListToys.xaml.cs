using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ListToys.xaml
    /// </summary>
    public partial class ListToys : Page
    {
        var4Entities1 context;
        public ListToys()
        {
            InitializeComponent();
            context = new var4Entities1();
            toyListView.ItemsSource = context.Toy.ToList();
        }

        private void ClickListToy(object sender, MouseButtonEventArgs e) { 
            Toy toy = (sender as Grid).DataContext as Toy;
            NavigationService.Navigate(new ToyElement(context, toy));
        }
    }
}
