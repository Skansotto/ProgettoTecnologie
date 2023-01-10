using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JMBet
{
    public class connessione
    {
        public TcpClient client;
        public bool toClose = false;

        private static connessione _instance = null;

        private connessione() { }

        Byte[] data;

        public static connessione getInstance()
        {
            if (_instance == null)
                _instance = new connessione();

            return _instance;
        }
        
        public void send(String mex) //Invia un messaggio al serverTCP, passato al metodo come "String mex"
        {
            while (stream.CanWrite == false) { }
            try
            {
                //Trasforma il mex in bytes e lo mette nell'array data
                data = System.Text.Encoding.Default.GetBytes(mex + "\r\nEND\r\n");

                // Client stream (lettura e scrittura) --> invia il messaggio al server TCP connesso
                stream.Write(data, 0, data.Length);
                stream.Flush();

                Console.WriteLine("Inviato: {0}", mex);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            stream.Flush();
        }

        public String recive() //Riceve messaggi inviati dal serverTCP
        {
            // Variabile in cui immagazzino il messaggio ricevito
            String responseData = "";

            while (stream.CanRead == false || stream.DataAvailable == false) { }

            try
            {
                while (stream.DataAvailable == true)
                {
                    // "data" serve a immagazzinare i byte della risposta
                    data = new Byte[256];

                    // Legge il primo gruppo di bytes della risposta
                    Int32 bytes = stream.Read(data, 0, data.Length);

                    responseData += System.Text.Encoding.Default.GetString(data, 0, bytes);
                }
                Console.WriteLine("Ricevuti: {0}", responseData);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (IOException) { }

            return responseData;
        }

        NetworkStream stream;

        public void setSocket(TcpClient socket, NetworkStream stream)
        {
            this.client = socket;
            this.stream = stream;
        }

        public TcpClient getSocket()
        {
            return client;
        }
    }
}
