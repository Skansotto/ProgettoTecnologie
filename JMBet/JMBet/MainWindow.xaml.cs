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

namespace JMBet
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_entra_Click(object sender, RoutedEventArgs e)
        {
            FinLog finLog = new FinLog();
            finLog.ShowDialog();
        }

        private void btn_iscriviti_Click(object sender, RoutedEventArgs e)
        {
            formiscri formiscri = new formiscri();  
            formiscri.ShowDialog(); 
        }
    }
}
