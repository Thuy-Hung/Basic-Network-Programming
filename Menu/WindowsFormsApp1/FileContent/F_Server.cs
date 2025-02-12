using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.FileContent
{
    public partial class F_Server : Form
    {
        public F_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            tb_Content.ReadOnly = true;
            tb_Path.ReadOnly = true;
            tb_Content.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        static string ReadFromClient(TcpClient client, NetworkStream stream)
        {
            byte[] buffer = new byte[2048];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }

        static void WriteToClient(TcpClient client, byte[] fileContents, NetworkStream stream)
        {
            byte[] fileLength = BitConverter.GetBytes(fileContents.Length);
            byte[] buffer = new byte[4+fileContents.Length];
            fileLength.CopyTo(buffer, 0);
            fileContents.CopyTo(buffer, 4);
            stream.Write(buffer, 0, 4+fileContents.Length);
        }
        bool CheckValidPath(string path)
        {
            if (path == null || path == String.Empty)
                return false;
            int pointIndex = path.IndexOf('.');
            if (pointIndex == -1)
                return false;
            else
            {
                string extension = path.Substring(pointIndex + 1);
                if (!File.Exists(path))
                    return false;
            }
            foreach (var character in path)
            {
                if (!Char.IsLetterOrDigit(character) && character != '.' && character != '\\' && character != ':' && character != '-' && character != '_')
                    return false;
            }
            return true;
        }
        TcpListener listener;
        void SendContent()
        {
            tb_Content.Text += "Server started!\r\nConnection accepted from 0.0.0.0:8080\r\n";
            while (true)
            {
                try
                {
                    listener = new TcpListener(IPAddress.Any, 8080);
                    listener.Start();
                    TcpClient client = listener.AcceptTcpClient();
                    if (client.Connected)
                    {
                        NetworkStream stream = client.GetStream();
                        string filePath = ReadFromClient(client, stream);
                        if (CheckValidPath(filePath))
                        {
                            try
                            {
                                WriteToClient(client, File.ReadAllBytes(filePath), stream);
                                tb_Path.Text = filePath;
                                tb_Path.Visible = true;
                                string extension = Path.GetExtension(filePath);
                                if (extension == ".txt" || extension == ".jpg" || extension == ".png" || extension == ".gif" || extension == ".bmp" || extension == ".tiff")
                                {
                                    IPEndPoint point = (IPEndPoint)client.Client.RemoteEndPoint;
                                    tb_Content.Text += "An Client from " + point.Address + ":" + point.Port + " connected:" + filePath + "\r\n";
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        else
                        {
                            byte[] fileContents = Encoding.UTF8.GetBytes("-1");
                            WriteToClient(client, fileContents, stream);
                        }
                    }
                    listener.Stop();
                }
                catch (Exception ex)
                {
                    if(ex.Message != "A blocking operation was interrupted by a call to WSACancelBlockingCall")
                        MessageBox.Show(ex.Message);
                    this.Close();
                    return;
                }
                
            }
        }
        private void pb_Off_Click(object sender, EventArgs e)
        {
            pb_On.BringToFront();
            tb_Content.Visible = true;
            Thread thread = new Thread(new ThreadStart(SendContent));
            thread.Start();
            thread.IsBackground = true;
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Server_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void F_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                    listener.Stop();
            }
            catch
            {

            }
        }
    }
}
