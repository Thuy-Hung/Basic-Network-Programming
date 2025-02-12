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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            panel_login.Dock = DockStyle.Fill;
            panel_main.Dock = DockStyle.Fill;
            Set_status(true);
        }
        private void Set_status(bool islogin)
        {
            if (islogin)
            {
                panel_login.Visible = true;
                panel_main.Visible = false;
                this.Width = 400;
                this.Height = 465;
            }
            else
            {
                panel_main.Visible = true;
                panel_login.Visible = false;
                this.Width = 670;
                this.Height = 630;
            }
        }
        TcpClient client;
        NetworkStream stream_send, stream_recv;

        async private void Connect()
        {
            int portn;
            IPAddress ipn;
            if (int.TryParse(port_input.Text, out portn) && IPAddress.TryParse(ip_input.Text, out ipn))
            {
                try
                {
                    client = new TcpClient();
                    await client.ConnectAsync(ip_input.Text, portn);
                    Set_status(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Thread recv = new Thread(Receivemessage);
                recv.Start();
                recv.IsBackground = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin địa chỉ IP và số port!");
            }
        }
        void Sendmessage(string s)
        {
            try
            {
                stream_send = client.GetStream();
                byte[] mess = Encoding.UTF8.GetBytes(s);
                stream_send.Write(mess, 0, mess.Length);
            }
            catch { }
        }
        void Receivemessage()
        {
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;
            stream_recv = client.GetStream();

            while (client.Connected)
            {
                try
                {
                    bytesRead = stream_recv.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    Result.Items.Add(mess);
                }
                catch { }

            }
            if (stream_recv != null) { stream_recv.Close(); }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            tenmien.Text = tenmien.Text.Trim();
            if (tenmien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên miền!");
            }
            else if (!checkBoxipv4.Checked && !checkBoxipv6.Checked)
            {
                MessageBox.Show("Vui lòng chọn IPv4 hoặc IPv6!");
            }
            else
            {
                Sendmessage(tenmien.Text.Trim() + " " + checkBoxipv4.Checked.ToString() + " " + checkBoxipv6.Checked.ToString());
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null) client.Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            client.Close();
            tenmien.Text = "";
            Result.Items.Clear();
            Set_status(true);
        }
    }
}
