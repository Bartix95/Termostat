using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace WindowsFormsApp1
{

    namespace Server
    {

        class Program
        {
            [STAThread]
            static void Main(string[] args)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Parallel.Invoke(ExecuteServer, RunForm);

                
            }
            public static void RunForm()
            {
                Application.Run(new Form1());
            }
            public static void ExecuteServer()
            {
                MessageBox.Show("Initializing");
                IPAddress Address = IPAddress.Parse("126.0.7.9");
                IPEndPoint localEndPoint = new IPEndPoint(Address, 11111);
                TcpListener TListener = new TcpListener(localEndPoint);

                Socket listener = new Socket(Address.AddressFamily,
                             SocketType.Stream, ProtocolType.Tcp);

                try
                {


                    listener.Bind(localEndPoint);


                    listener.Listen(30);

                    while (true)
                    {

                        Console.WriteLine("Waiting connection ... ");

                        Socket clientSocket = listener.Accept();

                        byte[] bytes = new Byte[1024];

                        byte[] b = new byte[100];
                        int k = clientSocket.Receive(b);
                        MessageBox.Show("received...");
                        string ReceivedMessage = Encoding.ASCII.GetString(b);
                        MessageBox.Show($"Piec podgrzewa temperaturę do {ReceivedMessage}");

                        ASCIIEncoding asen = new ASCIIEncoding();
                        clientSocket.Send(asen.GetBytes($"Piec podgrzewa temperaturę do {ReceivedMessage}" ));
                        clientSocket.Close();
                        TListener.Stop();


                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }

}

