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
    /// Логика взаимодействия для ToyElement.xaml
    /// </summary>
    public partial class ToyElement : Page
    {
        var4Entities1 context;
        public ToyElement(var4Entities1 context, Toy toy)
        {
            InitializeComponent();
            this.context = context;
            elementTable.ItemsSource = context.Toy.ToList().Where(x => x.id == toy.id).ToList();
        }
    }
}
