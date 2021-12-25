using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class FMainMenu : Form
    {
        Socket client;
        public FMainMenu(Socket client, string user)
        {
            this.client = client;
            InitializeComponent();
            label2.Text = user;
        }

       /* IPEndPoint server;
        Thread threadConnectServer;

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                threadConnectServer = new Thread(new ThreadStart(ConnectServer));
                threadConnectServer.IsBackground = true;
                threadConnectServer.Start();
            }
            catch
            {
                MessageBox.Show("Can't connect to this server!", "Notify", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            
        }

        private void ConnectServer()
        {
            try
            {
                server = new IPEndPoint(IPAddress.Parse(ipserverTextbox.Text), Int32.Parse(portTextbox.Text));
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(server);
                *//*Thread listenServer = new Thread(ReceiveMessage);
                listenServer.IsBackground = true;
                listenServer.Start();*//*
            }
            catch
            {
                server = new IPEndPoint(IPAddress.Parse(ipserverTextbox.Text), Int32.Parse(portTextbox.Text));
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
        }*/


        private void loadGridView(object sender) // MainMenu
        {
            client.Send(Serialize($"3{DateTime.Now.ToString("dd/MM/yyyy")}")); //send header 3 to load datagridview now
        }
        private void gunaGradientButton1_Click(object sender, EventArgs e) // Disconnect // Connect
        {
            client.Send(Serialize("5")); // send header 5 to disconnect
            client.Close();
            Application.Exit();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (tbSearch.Text == "")
            //    {
            //        client.Send(Serialize($"3{dateTimePicker1.Text}")); // send header 3 to load datagridview
            //    }
            //    else
            //    {
            //        client.Send(Serialize($"6{tbSearch.Text}@{dateTimePicker1.Text}"));
            //    }
            //}
        }
        private void CheckMessage(string mess) // MainMenu
        {
            if (mess == "success") //check login successfully
            {
                //metroTabControl1.SelectedTab = metroTabControl1.TabPages["show"];
                client.Send(Serialize($"3{datetimePicker.Text}")); // send header 3 to load datagridview
            }
            else if (mess == "unsuccess") //check login unsuccessfully
            {
                MessageBox.Show("Invalid password or username");
            }
            else if (mess == "success register") //check register successfully
            {
                MessageBox.Show("Register successfully");
            }
            else if (mess == "unsuccess register") //check register unsuccessfully
            {
                MessageBox.Show("Your username has been already exist");
            }
            else if (mess[0] == '1') // Load data into data grid view
            {
                goldDataGridView.Rows.Clear();


                string message = mess.Substring(1);
                string[] listGoldRate = message.Split('\n');

                int i = 0;
                int j = 0;

                //Show data
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        for (int k = 0; k < listGoldRate.Length / 6; k++)
                        {
                            goldDataGridView.Rows.Add();
                        }

                        foreach (String s in listGoldRate)
                        {
                            goldDataGridView.Rows[i].Cells[j].Value = s;
                            j++;
                            if (j == 6)
                            {
                                j = 0;
                                ++i;
                            }
                        }
                    }));
                }
                catch { };
            }
            else if(mess[0] == '7')
            {
                //Delete all value in Combobox
                guna2ComboBox1.Items.Clear();

                mess = mess.Substring(2); //Go header '7,'
                string[] type = mess.Split(',');
                foreach (string typeOption in type) {
                    guna2ComboBox1.Items.Add(typeOption);
                }
            }
            else if (mess == "no result")
            {
                statusTextBox.Text += "No result\r\n";
            }
        }

        private void ReceiveMessage() // MainMenu
        {
            try
            {
                //while (true)
                //{
                    byte[] buff = new byte[1024 * 5000];
                    int rec = client.Receive(buff);
                    string mess = (String)Deserialize(buff);

                    CheckMessage(mess);
                //}
            }
            catch
            {
                MessageBox.Show("Server is disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetimePicker_ValueChanged(object sender, EventArgs e)
        {
            //send header "3" to get information of day request
            client.Send(Serialize($"4{datetimePicker.Text}"));
            ReceiveMessage();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // send header "5" to disconnect
            client.Send(Serialize("5"));
            client.Close();
            Application.Exit();
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            client.Send(Serialize("7")); // send header "7" to get type of gold
            ReceiveMessage();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset dateTimePicker and combobox type
            datetimePicker.Value = DateTime.Now;
            guna2ComboBox1.SelectedItem = "";
            //load grid view
            loadGridView(client);
            ReceiveMessage();
        }

        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Send header '8' to get all formation of type gold request
            client.Send(Serialize($"8{guna2ComboBox1.Text}"));
            ReceiveMessage();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Send header '6' to search information of day and type request
            string date = datetimePicker.Text;
            //Convert date from mm/dd/yyyy to yyyymmdd
            string[] dates = date.Split('/');
            date = dates[2] + dates[0] + dates[1];
            //Get type of gold
            string type = guna2ComboBox1.SelectedItem.ToString();
            //Send and receive message
            client.Send(Serialize($"6{date}@{type}"));
            ReceiveMessage();
        }

    }
}
