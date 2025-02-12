using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DNS
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        public static IPAddress[] GetIPsByName(string hostName, string ip4Wanted, string ip6Wanted)
        {
            IPAddress outIpAddress;
            if (IPAddress.TryParse(hostName, out outIpAddress) == true)
                return new IPAddress[] { outIpAddress };

            IPAddress[] addresslist;
            try
            {
                addresslist = Dns.GetHostAddresses(hostName);
            }
            catch
            {
                return new IPAddress[0];
            }
            if (addresslist == null || addresslist.Length == 0)
                return new IPAddress[0];
            if (ip4Wanted == "True" && ip6Wanted == "True")
                return addresslist;
            else if (ip4Wanted == "True")
                return addresslist.Where(o => o.AddressFamily == AddressFamily.InterNetwork).ToArray();
            else if (ip6Wanted == "True")
                return addresslist.Where(o => o.AddressFamily == AddressFamily.InterNetworkV6).ToArray();
            return new IPAddress[0];
        }

        //------------------------------------------------------------------
        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();

        void Sendmessage(string s, TcpClient client)
        {
            NetworkStream stream_send;
            stream_send = client.GetStream();
            byte[] mess = Encoding.UTF8.GetBytes(s);
            stream_send.Write(mess, 0, mess.Length);
        }

        void Receivemessage(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream_recv;
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;
            stream_recv = client.GetStream();

            while (client.Connected)
            {
                try
                {
                    bytesRead = stream_recv.Read(buffer, 0, buffer.Length);
                }
                catch { return; }
                if (bytesRead == 0)
                {
                    break;
                }
                string[] mess = Encoding.UTF8.GetString(buffer, 0, bytesRead).Split(' ');
                IPAddress[] ips = GetIPsByName(mess[0], mess[1], mess[2]);
                if (ips.Count() != 0)
                    for (int i = 0; i < ips.Length; i++) Sendmessage(ips[i].ToString(), client);
                else Sendmessage("Không thể phân giải tên miền", client);
            }
            Client_list.Items.Add("Client " + client.Client.RemoteEndPoint + " has disconnected.");
            clients.Remove(client);
            if (client != null) { client.Close(); }
            if (stream_recv != null) { stream_recv.Close(); }
        }
        public async void serverThread()
        {
            int n;
            IPAddress ipip;
            if (int.TryParse(port_tb.Text, out n) && IPAddress.TryParse(ip_tb.Text, out ipip))
            {
                server = new TcpListener(ipip, n);
                server.Start();

                Client_list.Items.Add("Server started!...");
                while (true)
                {
                    TcpClient client;
                    try
                    {
                        client = await server.AcceptTcpClientAsync();
                    }
                    catch { return; }
                    Client_list.Items.Add("Accept client from " + client.Client.RemoteEndPoint);
                    clients.Add(client);
                    Thread recveive = new Thread(Receivemessage);
                    recveive.IsBackground = true;
                    recveive.Start(client);
                }
            }
            else
            {
                MessageBox.Show("Please re-enter the information");
            }
        }
        private void Disconnect()
        {
            Client_list.Items.Add("Server Stop!");
            foreach (TcpClient cl in clients) if (cl != null) cl.Close();
            clients.Clear();
            server.Stop();
        }
        //----------------------------------------------------------
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_disconnect.Visible = false;
            btn_Listen.Visible = true;
            Disconnect();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_disconnect.Visible = true;
            btn_Listen.Visible = false;
            serverThread();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clients.Count() > 0)
            {
                Disconnect();
            }
        }
    }
}
