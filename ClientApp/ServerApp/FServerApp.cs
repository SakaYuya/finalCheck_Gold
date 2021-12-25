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
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace ServerApp
{
    public partial class FServerApp : Form
    {
        public FServerApp()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void ListenClient()
        {
            server.Bind(ipe);
            server.Listen(3);

            while (true)
            {
                try
                {
                    Socket client = server.Accept();
                    clientList.Add(client);

                    clientActiTextbox.Text += $"{client.RemoteEndPoint.ToString()} connected.{Environment.NewLine}";
                    
                    Thread clientProcess = new Thread(myThreadClient);
                    clientProcess.IsBackground = true;
                    clientProcess.Start(client);

                    clientInUseTextbox.AppendText(client.RemoteEndPoint.ToString());
                }
                catch
                {

                }
            }
        }
        private void myThreadClient(object obj)
        {
            Socket client = (Socket)obj;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];

                    int receive = client.Receive(data);

                    string mess = (String)Deserialize(data);

                    clientActiTextbox.Text += $"{mess}{Environment.NewLine}";

                    if (mess[0] == '1') // check login successfully ?
                    {
                        int index = mess.IndexOf('@');
                        string username = mess.Substring(1, index - 1);
                        string password = mess.Substring(index + 1);

                        if (sqlManager.CheckAccount(username, password))
                        {
                            string s = "success";
                            SendMessage(client, s);
                        }
                        else
                        {
                            string s = "unsuccess";
                            SendMessage(client, s);
                        }
                    }
                    else if (mess[0] == '2') // check register successfully ?
                    {
                        int index = mess.IndexOf('@');
                        string username = mess.Substring(1, index - 1);
                        string password = mess.Substring(index + 1);

                        if (sqlManager.CheckAccountRegister(username, password))
                        {
                            string s = "success register";
                            SendMessage(client, s);
                        }
                        else
                        {
                            string s = "unsuccess register";
                            SendMessage(client, s);
                        }
                    }
                    else if (mess[0] == '3') //Load first data grid view
                    {
                        //Parse dd/mm/yyyy to yyyymmdd
                        string s = mess.Substring(1);
                        string[] ss = s.Split('/');
                        s = "";
                        foreach(string ss2 in ss)
                        {
                            s = ss2 + s;
                        }
                        DataTable dt = sqlManager.GetDataTable();

                        /*if (dt.Rows.Count == 0)
                        {
                            sqlManager.GetJson();
                            dt = sqlManager.GetDataTable(s);
                        }*/

                        string message = "";

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //type,brand,company,buy,sell,updated
                            string type = dt.Rows[i][0].ToString();
                            string brand = dt.Rows[i][1].ToString();
                            string company = dt.Rows[i][2].ToString();
                            string buy = dt.Rows[i][3].ToString();
                            string sell = dt.Rows[i][4].ToString();
                            string updated = dt.Rows[i][5].ToString();

                            message += $"{type}\n{brand}\n{company}\n{buy}\n{sell}\n{updated}\n";
                        }

                        client.Send(Serialize($"1{message}"));

                    }
                    else if (mess[0] == '4') // load datagridview of day request for client 
                    {
                        string s = mess.Substring(1);
                        //Parse mm/dd/yyyy to yyyymmdd
                        string[] ss = s.Split('/');
                        s = ss[2] + ss[0] + ss[1];
                        DataTable dt = sqlManager.GetDataTable_Date(s);
                        string message = "";

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //id,type,brand,company,buy,sell,updated
                            string type = dt.Rows[i][0].ToString();
                            string brand = dt.Rows[i][1].ToString();
                            string company = dt.Rows[i][2].ToString();
                            string buy = dt.Rows[i][3].ToString();
                            string sell = dt.Rows[i][4].ToString();
                            string updated = dt.Rows[i][5].ToString();

                            message += $"{type}\n{brand}\n{company}\n{buy}\n{sell}\n{updated}\n";
                        }

                        SendMessage(client, $"1{message}");
                    }
                    else if (mess[0] == '5')
                    {
                        foreach (Socket item in clientList)
                        {
                            //ip and port = RemoteEndPoint
                            if (item.RemoteEndPoint.ToString() == client.RemoteEndPoint.ToString())
                            {
                                clientActiTextbox.Text += $"{client.RemoteEndPoint.ToString()} is disconnect{Environment.NewLine}";
                            }
                        }
                    }
                    else if (mess[0] == '6')
                    {
                        int index = mess.IndexOf('@');
                        string s = mess.Substring(1, index - 1);
                        string type1 = mess.Substring(index + 1);
                        DataTable dt = sqlManager.GetDataTableDate_Type(s, type1);

                        if (dt.Rows.Count == 0)
                        {
                            foreach (Socket item in clientList)
                            {
                                //ip and port = RemoteEndPoint
                                if (item.RemoteEndPoint.ToString() == client.RemoteEndPoint.ToString())
                                {
                                    client.Send(Serialize("no result"));
                                }
                            }
                            continue;
                        }

                        string message = "";

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //id,type,brand,company,buy,sell,updated
                            string type = dt.Rows[i][0].ToString();
                            string brand = dt.Rows[i][1].ToString();
                            string company = dt.Rows[i][2].ToString();
                            string buy = dt.Rows[i][3].ToString();
                            string sell = dt.Rows[i][4].ToString();
                            string updated = dt.Rows[i][5].ToString();

                            message += $"{type}\n{brand}\n{company}\n{buy}\n{sell}\n{updated}\n";
                        }

                        SendMessage(client, $"1{message}");
                    }
                    else if (mess[0] == '7') //Get gold type
                    {
                        string message = "7";
                        message += sqlManager.getGoldType();
                        //Send all type of gold to client with header "7"
                        SendMessage(client, message);
                    }
                    else if(mess[0] == '8')
                    {
                        //Get all information of type gold request
                        string s = mess.Substring(1);
                        DataTable dt = sqlManager.GetDataTable_Type(s);
                        string message = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //id,type,brand,company,buy,sell,updated
                            string type = dt.Rows[i][0].ToString();
                            string brand = dt.Rows[i][1].ToString();
                            string company = dt.Rows[i][2].ToString();
                            string buy = dt.Rows[i][3].ToString();
                            string sell = dt.Rows[i][4].ToString();
                            string updated = dt.Rows[i][5].ToString();

                            message += $"{type}\n{brand}\n{company}\n{buy}\n{sell}\n{updated}\n";
                        }
                        //Send message
                        client.Send(Serialize($"1{message}"));
                    }
                }
            }
            catch
            {
                return;
            }
        }

        SQLManager sqlManager = new SQLManager();
        IPEndPoint ipe;
        Socket server;
        List<Socket> clientList = new List<Socket>();
        string myIP = "";
        Thread threadListenClient;
        Thread threadUpdate;

        private void SendMessage(Socket client, string message)
        {
            foreach (Socket item in clientList)
            {
                //ip and port = RemoteEndPoint
                if (item.RemoteEndPoint.ToString() == client.RemoteEndPoint.ToString())
                {
                    byte[] msg = Serialize(message);
                    client.Send(msg);
                }
            }
        }
        public void GetIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress address in host.AddressList)
            {
                if (address.AddressFamily.ToString() == "InterNetwork")
                {
                    myIP = address.ToString();
                }
            }
            myIP = ipserverTextbox.Text;
            ipe = new IPEndPoint(IPAddress.Parse(myIP), int.Parse(portTextbox.Text));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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

        private void startButton_Click(object sender, EventArgs e)
        {
            clientActiTextbox.Text += $"Start open connecting ...{Environment.NewLine}";
            GetIP();
            threadListenClient = new Thread(new ThreadStart(ListenClient));
            threadListenClient.IsBackground = true;
            threadListenClient.Start();
            startButton.Enabled = false;
            stopButton.Enabled = true;
            
            //Update db every 30 minutes
            threadUpdate = new Thread(new ThreadStart(sqlManager.GetJson));
            threadUpdate.IsBackground = true;
            threadUpdate.Start();            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            server.Close();
            clientActiTextbox.AppendText("Server stop !!!");
            clientActiTextbox.AppendText(Environment.NewLine);
            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientActiTextbox_TextChanged(object sender, EventArgs e)
        {
            clientActiTextbox.ScrollBars = ScrollBars.Vertical;
        }

        private void clientInUseTextbox_TextChanged(object sender, EventArgs e)
        {
            clientInUseTextbox.ScrollBars = ScrollBars.Vertical;
        }

        //private void clientInUseTextbox_Textchanged(object sender, EventArgs e)
        //{
        //    clientInUseTextbox.ScrollBars = ScrollBars.Vertical;
        //}

        //private void clientActiTextbox_Textchanged(object sender, EventArgs e)
        //{
        //    clientActiTextbox.ScrollBars = ScrollBars.Vertical;
        //}
    }
}
