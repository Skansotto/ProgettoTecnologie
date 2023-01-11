using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleTCP;
using System.IO;
using System.Windows.Markup;
using static System.Net.Sockets.TcpClient;

namespace JMBet
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string serverName = "localhost";
        
        public FinLog finLog = new FinLog();
        public HomeWindow home = new HomeWindow();
        public ClientSocket clientsocket = new ClientSocket(1234);
        public MainWindow()
        {
            try
            {
                
                
                InitializeComponent();
            }
            catch
            {
                catcherrore err = new catcherrore();
                err.ShowDialog();
                this.Close();
            }

            
            
        }

        //Instaura connessione con sever TCP
        //static void DoConnect(String server, String message)
        //{
        //    try
        //    {
        //        int port = 8080;

        //        TcpClient client = new TcpClient(server, port);

        //        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

        //        NetworkStream stream = client.GetStream();

        //        stream.Write(data, 0, data.Length);

        //        Console.WriteLine("Sent: {0}", message);

        //        data = new Byte[256];

        //        String responseData = String.Empty;

        //        Int32 bytes = stream.Read(data, 0, data.Length);

        //        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

        //        Console.WriteLine("Received: {0}", responseData);

        //    }
        //    catch
        //    (ArgumentNullException e)
        //    {
        //        Console.WriteLine("ArgumentNullException: {0}", e);
        //    }

        //}

        private void btn_entra_Click(object sender, RoutedEventArgs e)
        {
            
            
            

            this.Hide();

            if(finLog.ShowDialog()==true)
            {
                this.Hide();
                finLog.Hide();
                try
                {
                    clientsocket.Run();

                }
                catch
                {
                    catcherrore err = new catcherrore();
                    err.ShowDialog();
                    this.Close();
                }

              
                home.Show();
            }
            else
            {
                this.Show();
            }

            connessione instanza = connessione.getInstance();
            instanza.send("skjgdfl");
            //inizializzare collegamento a server TCP
            //DoConnect(serverName, "Hi");

        }

        
    }
}
