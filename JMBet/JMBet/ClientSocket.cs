using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JMBet
{
    public class ClientSocket
    {
        private int PORT;
        public TcpClient socket;
        NetworkStream stream;

        public String m;

        public Boolean newMex;
        public Boolean messaggioCoda;

        //costruttore con parametro porta della socket Client
        public ClientSocket(int port)
        {
            this.PORT = port;
            //socket = new TcpClient(addr, PORT);
            socket = new TcpClient();
            socket.Connect("localhost", port);
            stream = socket.GetStream();
            newMex = false;
            messaggioCoda = false;

            connessione instanza = connessione.getInstance();
            instanza.setSocket(socket, stream);
        }

        public void Run()
        {
            connessione instanza = connessione.getInstance();
            //String line = "END";
            try
            {
                //instanza.setSocket(socket,stream);
                while (true)
                {
                    try
                    {
                        String line = instanza.recive();
                        m = line;
                        if (line != "ok\r\n")
                        {
                            newMex = true;
                            Console.WriteLine("Ricevuto dal server: " + line);
                        }
                        if (m.StartsWith("messInArr"))
                        {
                            messaggioCoda = true;
                        }
                    }
                    catch (IOException)
                    {

                    }
                }
            }
            catch (IOException)
            {
                instanza.toClose = true;  //impossibile prendere lo stream di input
                return;
            }
        }
    }
}
