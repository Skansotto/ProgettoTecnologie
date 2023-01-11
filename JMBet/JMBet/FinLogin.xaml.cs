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

namespace JMBet
{
    /// <summary>
    /// Logica di interazione per FinLog.xaml
    /// </summary>
    public partial class FinLog : Window
    {
        public FinLog()
        {
            InitializeComponent();
        }

        private void text_user_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //useless
        }

        private void text_user_TextChanged(object sender, TextChangedEventArgs e)
        {
            //useless
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow home = new HomeWindow();
            home.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             formiscri formiscri = new formiscri();
            formiscri.ShowDialog();
    }
    }
}
