using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileContent
{
    public partial class F_Client : Form
    {
        public F_Client()
        {
            InitializeComponent();
            tb_Content.ReadOnly = true;
            tb_Path_Cl.ReadOnly = true;
            tb_Content.Visible = false;
            pb_Content.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void F_Client_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        static byte[] ReadFromServer(TcpClient client, NetworkStream stream)
        {
            stream = client.GetStream();
            byte[] length = new byte[4], buffer;
            int bytesRead = stream.Read(length, 0, 4);
            int contentLength = BitConverter.ToInt32(length, 0);
            buffer = new byte[contentLength];
            bytesRead = stream.Read(buffer, 0, contentLength);
            return buffer;
        }

        static void WriteToServer(TcpClient client, string filePath, NetworkStream stream)
        {
            stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(filePath);
            stream.Write(buffer, 0, buffer.Length);
        }
        void Connect()
        {
            try
            {
                if (tb_Path_Sv.Text == String.Empty)
                {
                    MessageBox.Show("Enter file path!", "\tEmpty path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TcpClient client = new TcpClient("127.0.0.1", 8080);
                string filePath = tb_Path_Sv.Text;
                NetworkStream stream = client.GetStream();
                WriteToServer(client, filePath, stream);
                byte[] fileContents = ReadFromServer(client, stream);
                string cons = Encoding.UTF8.GetString(fileContents);
                if (cons == "-1")
                {
                    MessageBox.Show("The path is incorrect, the file is not on the server!", "\tRead failed content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog save = new SaveFileDialog();
                string extension = Path.GetExtension(filePath);
                if (extension == ".txt")
                {
                    save.Filter = "Text File|*.txt";
                    save.FileName = "output.txt";
                    pb_Content.Visible = false;
                    tb_Content.Visible = true;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = save.FileName;
                        FileStream fileStream = new FileStream(savePath, FileMode.OpenOrCreate, FileAccess.Write);
                        fileStream.Write(fileContents, 0, fileContents.Length);
                        fileStream.Close();
                        fileStream = new FileStream(savePath, FileMode.Open, FileAccess.Read);
                        StreamReader streamReader = new StreamReader(fileStream);
                        tb_Content.Text = String.Empty;
                        tb_Content.Text = streamReader.ReadToEnd();
                        streamReader.Close();
                        fileStream.Close();
                        tb_Path_Cl.Text = savePath;
                    }
                }
                else if (extension == ".jpg" || extension == ".png" || extension == ".gif" || extension == ".bmp" || extension == ".tiff")
                {
                    save.Filter = "Image|*" + extension;
                    save.FileName = "output" + extension;
                    tb_Content.Visible = false;
                    pb_Content.Visible = true;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = save.FileName;
                        FileStream fileStream = new FileStream(savePath, FileMode.OpenOrCreate);
                        fileStream.Write(fileContents, 0, fileContents.Length);
                        fileStream.Close();
                        Image img = Image.FromFile(savePath);
                        pb_Content.Image = img;
                        tb_Path_Cl.Text = savePath;
                    }
                }
                else
                {
                    pb_Content.Visible = false;
                    tb_Content.Visible = false;
                    MessageBox.Show("Unsupported file format!", "\tFailed to read content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lb_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void pb_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void lb_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
