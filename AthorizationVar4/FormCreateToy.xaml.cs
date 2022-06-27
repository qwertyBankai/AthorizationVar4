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
    /// Логика взаимодействия для FormCreateToy.xaml
    /// </summary>
    public partial class FormCreateToy : Page
    {
        var4Entities1 context;
        public FormCreateToy()
        {
            InitializeComponent();
            context = new var4Entities1();

            combo.ItemsSource = context.Toy.ToList();
        }

        private void CreateForm(object sender, RoutedEventArgs e)
        {
            if(context.Client.Any(x=> x.passport == passportBox.Text))
            {
                if(context.Client.Any(x=>x.name == fioBox.Text))
                {
                    int idMax = context.Order.Max(x => x.id);

                    Order order = new Order()
                    {
                        id = idMax + 1,
                        idClent = Convert.ToInt32(idBox.Text),
                        date = DateTime.Now,
                        state = 2
                    };
                }
            }
        }
    }
}
