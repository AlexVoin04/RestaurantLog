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
using System.Windows.Shapes;

namespace RestaurantLog
{
    /// <summary>
    /// Логика взаимодействия для HREWindow.xaml
    /// </summary>
    public partial class HREWindow : Window
    {
        public HREWindow(string allname, int idpost)
        {
            InitializeComponent();
            tbl_fio.Text = "Здравствуйте, " + allname;

            switch (idpost)
            {
                case 2:
                    //tb_login.Visibility = Visibility.Collapsed;//не создает
                    CreateMenu(ti_dishes);CreateMenu(ti_orders);CreateMenu(ti_ordersinfo);CreateMenu(ti_ordersstatus);CreateMenu(ti_products);CreateMenu(ti_purchases);
                    break;
                case 3:
                    CreateMenu(ti_employees); CreateMenu(ti_orders); CreateMenu(ti_ordersinfo); CreateMenu(ti_ordersstatus);
                    break;
                case 4:
                    CreateMenu(ti_dishes); CreateMenu(ti_orders); CreateMenu(ti_employees); CreateMenu(ti_products); CreateMenu(ti_purchases);
                    break;
                case 5:
                    CreateMenu(ti_dishes);  CreateMenu(ti_employees); CreateMenu(ti_products); CreateMenu(ti_purchases); CreateMenu(ti_ordersstatus);
                    break;
            }

        }
        public void CreateMenu(TabItem tabItem)
        {
            tabItem.Visibility = Visibility.Collapsed;
        }

        private void bt_end_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow newform = new MainWindow();
            newform.ShowDialog();
            Close();
        }
    }
}
