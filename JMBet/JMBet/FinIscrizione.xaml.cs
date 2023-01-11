using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Logica di interazione per formiscri.xaml
    /// </summary>
    public partial class formiscri : Window
    {

        public formiscri()
        {
            
            InitializeComponent();
            
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if(txtpass.Equals(txtpass2))
            {
                string mailpas = "inziotrasm " + txtBoxUtente.Text +" "+ txtpass;
                
            }
            else
            {
                
                MessageBox.Show("le due password non corrispondono");
            }
            
        }

        public string getCredenziali() {

            string mailpass = "inziotrasm\r\n" + txtBoxUtente.Text + "\r\n" + txtpass;
            return mailpass;

        }
    }
}
