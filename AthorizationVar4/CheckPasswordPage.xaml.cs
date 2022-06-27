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
    /// Логика взаимодействия для CheckPasswordPage.xaml
    /// </summary>
    public partial class CheckPasswordPage : Page
    {
        var4Entities1 dataClasses2;
        public CheckPasswordPage()
        {
            InitializeComponent();
            dataClasses2 = new var4Entities1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckPassword(object sender, RoutedEventArgs e)
        {
            int login = Convert.ToInt32(inputLogin.Text);
            string fio = Convert.ToString(inputFio.Text);
            string state = Convert.ToString(inputState.Text);
            string dateInWork = inputDate.Text;

            if(dataClasses2.Employer.Any(x => x.tabNum == login))
            {
                Employer emps = dataClasses2.Employer.ToList().Find(x => x.tabNum == login);

                if (emps.name.Equals(fio)){
                    if (emps.Position1.Equals(state))
                    {
                        string dateMore = emps.dateStartWork.ToShortDateString();

                        if (dateMore.Equals(dateInWork))
                        {
                            MessageBox.Show($"Ваш пароль {emps.password}");
                        }
                        else
                        {
                            MessageBox.Show("Не правильные данные");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не правильные данные");
                    }
                }
                else
                {
                    MessageBox.Show("Не правильные данные");
                }
            }
            else
            {
                MessageBox.Show("Не правильные данные");
            }
        }
    }
}
