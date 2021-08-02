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

namespace yameApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string role;
        public string name;
        bool admin;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LblExit_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblExit.Foreground = Brushes.LightBlue;
        }

        private void LblExit_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            lblExit.Foreground = Brushes.Black;
        }

        private void LblExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = new MessageBoxResult();
            result = MessageBox.Show("Вы уверены что хотите выйти?", "Предупреждение", MessageBoxButton.YesNo); //Предупреждение
            if (result == MessageBoxResult.Yes)
            {
                auth a = new auth();
                a.Show();
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (role != "admin")
            {
                admin = false;
                btnGain.IsEnabled = false;
                btnSalary.IsEnabled = false;
                btnStorage.IsEnabled = false;
                lblCurrentUser.Content = $"Текущий пользователь : {name}";
            }
            else
            {
                admin = true;
                lblCurrentUser.Content = $"Текущий пользователь : {name} (admin)";
            }
        }

        private void BtnCards_Click(object sender, RoutedEventArgs e)
        {
            clientCards cc = new clientCards();
            cc.Show();
            Close();
        }

        private void BtnFirstShop_Click(object sender, RoutedEventArgs e)
        {
            firstShop firstShop = new firstShop();
            firstShop.Show();
            Close();
        }

    }
}
