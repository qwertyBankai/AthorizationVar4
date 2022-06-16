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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        var4Entities context;
        public MainPage()
        {
            InitializeComponent();
            context = new var4Entities();
            masterTable.ItemsSource = context.Employer.ToList();
            StatusCombo.ItemsSource = context.State.ToList();
        }

        public void SortDataEmp()
        {
            var list = context.Employer.ToList();

            if (StatusCombo.SelectedIndex >= 0)
            {
                State state = StatusCombo.SelectedItem as State;
                list = list.Where(x => x.State == state.id).ToList();
            }

            if (!string.IsNullOrWhiteSpace(fioBox.Text))
            {
                list =list.Where(x => x.name.ToLower().Contains(fioBox.Text.ToLower())).ToList();
            }
            masterTable.ItemsSource = list;


        }

        private void SelectStatus(object sender, SelectionChangedEventArgs e)
        {
            SortDataEmp();
        }

        private void SearchByFio(object sender, TextChangedEventArgs e)
        {
            SortDataEmp();
        }

        private void GoAddMasterPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMasterPage(context));
        }

        private void EditMaster(object sender, RoutedEventArgs e)
        {
            Employer employer = masterTable.SelectedItem as Employer;
            NavigationService.Navigate(new AddMasterPage(context, employer));
        }

        private void DeleteMaster(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Employer employer = masterTable.SelectedItem as Employer;
                    context.Employer.Remove(employer);
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении");
                }
            }
        }
    }
}
