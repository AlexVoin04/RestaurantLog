using RestaurantLog.Model;
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

namespace RestaurantLog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //tb_login.Visibility = Visibility.Collapsed;//не создает
            //tb_login.Visibility = Visibility.Hidden;//скрывает
        }

        private void btn_LogIn_Click(object sender, RoutedEventArgs e)
        {
            lb_NotAuthorization.Visibility = Visibility.Hidden;
            //lb_Authorization.Visibility = Visibility.Hidden;
            RestaurantEntities db = Helper.GetContext();

            string login = tb_login.Text;
            string password = tb_password.Password;

            Hash hash = new Hash();

            var authorization = db.Authorization;
            string passhash = hash.sha256_hash(password);

            var user = authorization.Where(x => x.Login == login && x.Password == passhash).FirstOrDefault();
            if (user != null)
            {
                int idpost = user.EmployeeInformation.Posts.ID;
                string name = user.EmployeeInformation.Employees.Name;
                string patronymic = user.EmployeeInformation.Employees.Patronymic;    
                string allame = name + " " + patronymic;
                //lb_Authorization.Visibility = Visibility.Visible;
                Hide();
                HREWindow newform1 = new HREWindow(allame, idpost);
                newform1.ShowDialog();
                Close();
                //MessageBox.Show(idpost.ToString());
                /*
                switch (idpost)
                {
                    case 2:
                        Hide();
                        HREWindow newform1 = new HREWindow(allame, idpost);
                        newform1.ShowDialog();
                        Close();
                        break;
                    case 3:
                        Hide();
                        HREWindow newform2 = new HREWindow(allame);
                        //ManagerWindow newform2 = new ManagerWindow();
                        newform2.ShowDialog();
                        Close();
                        break;
                    case 4:
                        Hide();
                        HREWindow newform3 = new HREWindow(allame);
                        //SousСhefWindow newform3 = new SousСhefWindow();
                        newform3.ShowDialog();
                        Close();
                        break;
                    case 5:
                        Hide();
                        HREWindow newform4 = new HREWindow(allame);
                        //WaiterWindow newform4 = new WaiterWindow();
                        newform4.ShowDialog();
                        Close();
                        break;
                }*/
            }
            else
            {
                lb_NotAuthorization.Visibility = Visibility.Visible;
                //lb_NotAuthorization.Content = "Неправильный логин или пароль";
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
;       }
    }
}
