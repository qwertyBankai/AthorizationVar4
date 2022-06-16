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
    /// Логика взаимодействия для AddMasterPage.xaml
    /// </summary>
    public partial class AddMasterPage : Page
    {
        bool flag;
        var4Entities context;
        public AddMasterPage(var4Entities cont)
        {
            InitializeComponent();
            context = cont;
            flag = true;
        }

        Employer emp;

        public AddMasterPage(var4Entities cont, Employer employer)
        {
            InitializeComponent();
            context = cont;

            emp = employer;

            tabBox.Text = emp.tabNum.ToString();
            fioBox.Text = emp.name;
            emp.position = 2;
            salaryBox.Text = emp.salary.ToString();
            passwordBox.Text = emp.password;
            stateBox.Text = emp.State.ToString();

            flag = false;
        }

        private void AddNewMaster(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                Employer employer = new Employer()
                {
                    tabNum = Convert.ToInt32(tabBox.Text),
                    name = fioBox.Text,
                    dateStartWork = Convert.ToDateTime(dateBox.Text),
                    position = 2,
                    salary = Convert.ToDecimal(salaryBox.Text),
                    password = passwordBox.Text,
                    State = Convert.ToInt32(stateBox.Text)
                };
                context.Employer.Add(employer);
                context.SaveChanges();

                NavigationService.Navigate(new MainPage());
            }
            else
            {
                context.Employer.Find(emp.tabNum).name = fioBox.Text;
                context.Employer.Find(emp.tabNum).position = 2;
                context.Employer.Find(emp.tabNum).salary = Convert.ToDecimal(salaryBox.Text);
                context.Employer.Find(emp.tabNum).password = passwordBox.Text;
                context.Employer.Find(emp.tabNum).State = Convert.ToInt32(stateBox.Text);

                context.SaveChanges();
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
