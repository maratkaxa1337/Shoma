using Praduct_Pull.Context;
using Praduct_Pull.Views.Pages.Admin;
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

namespace Praduct_Pull.Views.Pages.Login
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnChancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = ConnectContext.db.SignIn.FirstOrDefault(item => item.Username == txbUsername.Text && item.Password == psbPassword.Password);
                if (currentUser != null)
                {
                    switch (currentUser.RoleID)
                    {
                        case "A  ":
                            MessageBox.Show("Здравстуйте адмниистратор  " + currentUser.Username, "Приятной Работы", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new DataViewPage());
                            break;
                        case "U":
                            MessageBox.Show("Здраствуйте пользователь" + currentUser.Username, "Приятной работы", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }
                }
                    else
                    {
                        MessageBox.Show("Вы ввели не верные данные", "Zoo Animals", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
