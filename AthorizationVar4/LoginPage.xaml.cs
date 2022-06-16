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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        var4Entities dataClasses2;
        public LoginPage()
        {
            InitializeComponent();
            dataClasses2 = new var4Entities();
        }
        int count = 0;
        private void GoLogIn(object sender, RoutedEventArgs e)
        {
            int login = Convert.ToInt32(inputLogin.Text);
            string password = Convert.ToString(inputPassword.Text);

            if (dataClasses2.Employer.Any(x => x.tabNum == login))
            {
                Employer emp = dataClasses2.Employer.ToList().Find(x => x.tabNum == login);

                if (emp.password.Equals(inputPassword.Text))
                {
                    MessageBox.Show("Добро пожаловать");
                    NavigationService.Navigate(new maket());
                }
                else
                {
                    MessageBox.Show("Неверный логин/пароль");
                    count++;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин/пароль");
                count++;
            }
            if(count >= 3)
            {
                check.Visibility = Visibility.Visible;
            }

        }

        private void GoCheckPassword(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckPasswordPage());
        }
    }
}
