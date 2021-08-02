using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace yameApp
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        public auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String login = tbLogin.Text;
            String pass = tbPass.Text;
            Context db = new Context();
            foreach (var item in db.users)
            {
                if ((item.login ==login) && (item.password==pass))
                {
                    MessageBox.Show($"Вы авторизовались, {item.name}.");
                    MainWindow mw = new MainWindow();
                    mw.name = item.name;
                    mw.role = item.role;
                    mw.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
           

        }
    }
}
