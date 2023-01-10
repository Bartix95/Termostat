using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int temperatura = 22;
        int temperturakoncowa = 22;
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void zmienbtn_Click(object sender, EventArgs e)
        {
            wyslijTemperaturaDoPieca();
          
            TEMP.Text = TempAk.Text;
        }

        private void Temp1_Click(object sender, EventArgs e)
        {

        }

        private void TEMP_Click(object sender, EventArgs e)
        {


        }


        private void wyzejbtn_Click(object sender, EventArgs e)
        {
            temperatura++;
            TempAk.Text = temperatura.ToString();
        }

        private void nizejbtn_Click(object sender, EventArgs e)
        {
            temperatura--;
            TempAk.Text = temperatura.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void wyslijTemperaturaDoPieca()
        {

            TcpClient client = new TcpClient();
            IPEndPoint piecIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11111);

            try
            {
                client.Connect(piecIP);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.ASCII.GetBytes(temperatura.ToString());
                stream.Write(data, 0, data.Length);

                stream.Close();
                client.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Nie udało się połączyć z piecem: " + ex.Message);
            }
           try
            {
                client.Connect(piecIP);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.ASCII.GetBytes(temperatura.ToString());
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
            }
            catch (SocketException)
            {
                MessageBox.Show("nie wiem");
            }

    }

    }
}
