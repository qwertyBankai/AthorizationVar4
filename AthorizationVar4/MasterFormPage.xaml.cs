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
    /// Логика взаимодействия для MasterFormPage.xaml
    /// </summary>
    public partial class MasterFormPage : Page
    {
        var4Entities1 context;
        public MasterFormPage()
        {
            InitializeComponent();
            context = new var4Entities1();
            selectedOrderBox.ItemsSource = context.Order.ToList();
            combo.ItemsSource = context.ToyMaterial.ToList();
        }

        private void CreateForm(object sender, RoutedEventArgs e)
        {
            Order order = selectedOrderBox.SelectedItem as Order;
            order.state = Convert.ToInt32(stateBox.Text);
            context.SaveChanges();


            Material material = combo.SelectedItem as Material;
            context.SaveChanges();
        }

        private void selectId(object sender, SelectionChangedEventArgs e)
        {
            if (selectedOrderBox.SelectedIndex >= 0)
            {
                Order order = selectedOrderBox.SelectedItem as Order;
                stateBox.Text = order.TakeState.ToString();
            }
        }
    }
}
