using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DNS;

namespace WindowsFormsApp1
{
    public partial class dns : Form
    {
        public dns()
        {
            InitializeComponent();
        }

        private void iconServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void iconClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
