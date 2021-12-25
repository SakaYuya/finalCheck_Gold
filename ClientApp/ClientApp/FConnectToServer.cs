using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class FConnectToServer : Form    {
        Socket client;
        public FConnectToServer()
        {
            InitializeComponent();
        }

        bool ConnectToServer()
        {
            //serverIP = new IPEndPoint(IPAddress.Parse(ipserverTextbox.Text), Int32.Parse(portTextbox.Text));
            //clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //try
            //{
            //    clientSocket.Connect(serverIP);
            //    Thread clientListen = new Thread(ReceiveFromServer);
            //    clientListen.IsBackground = true;
            //    clientListen.Start();
            //}
            //catch
            //{
            //    return false;
            //}
            //return true;
            try
            {
                //Get ip address
                IPAddress address = IPAddress.Parse(ipserverTextbox.Text);
                //Get port
                int port = int.Parse(portTextbox.Text);
                //Create socket
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect Socket
                client.Connect(address, port);
 
            }
            catch
            {
                return false;
            }
            return true;
        }

        void ReceiveFromServer()
        {
            //try
            //{
            //    byte[] dataFromServer = new byte[1024 * 5000];
            //    clientSocket.Receive(dataFromServer);
            //    //string message = (string)Deserialize(dataFromServer);
            //}
            //catch
            //{
            //    MessageBox.Show("Server is Disconnected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(ConnectToServer())
            {
                try
                {
                    this.Hide();
                    FClientLogIn fLogin = new FClientLogIn(client);
                    fLogin.ShowDialog();
                    this.Show();
                }
                catch
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to this server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendRequest(string request)
        {
            byte[] buffer = new byte[request.Length];
            buffer = Encoding.ASCII.GetBytes(request);
            client.Send(buffer, 0, buffer.Length, SocketFlags.None);

        }

        private byte[] ReveiceRespone()
        {
            byte[] buffer = new byte[1024];
            int received = client.Receive(buffer, SocketFlags.None);
            if (received == 0) return null;
            return buffer;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

            //SendRequest("Disconnect");
        }


    }
}
