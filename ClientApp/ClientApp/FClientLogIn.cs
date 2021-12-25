using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClientApp
{
    public partial class FClientLogIn : Form
    {
        Socket client;
        public FClientLogIn(Socket client)
        {
            this.client = client;
            InitializeComponent();            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        bool checkLogIn(string username, string password)
        {
            string request = $"1{username}@{password}";// send header "1" to check username, password
            client.Send(Serialize(request));
            //ReceiveMessage
            try
            {
                //while (true)
                //{
                byte[] buff = new byte[1024 * 5000];
                int rec = client.Receive(buff);
                string mess = (String)Deserialize(buff);

                if(mess == "success")
                {
                    return true;
                }
                else if(mess =="unsuccess")
                {
                    return false;
                }
                //}
            }
            catch
            {
                MessageBox.Show("Server is disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (checkLogIn(usernameTextbox.Text, passwordTextbox.Text))
            {
                this.Hide();
                FMainMenu fMainMenu = new FMainMenu(client, usernameTextbox.Text);
                fMainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Log in failed", "Notify", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string user = usernameCreateTextbox.Text;
            string pass = passwordCreateTextbox.Text;
            //Dang ki hop le
            if(user != "" && pass != "" && pass == re_passwordCreateTextbox.Text)
            {
                //Gui thong tin len server
                string request = $"2{user}@{pass}";
                client.Send(Serialize(request));
                //ReceiveMessage
                try
                {
                    //while (true)
                    //{
                    byte[] buff = new byte[1024 * 5000];
                    int rec = client.Receive(buff);
                    string mess = (String)Deserialize(buff);

                    if (mess == "success register")
                    {
                        MessageBox.Show("Register successfully!", "Success", MessageBoxButtons.OK);
                    }
                    else if (mess == "unsuccess register")
                    {
                        MessageBox.Show("Username has already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //}
                }
                catch
                {
                    MessageBox.Show("Server is disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Register failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
