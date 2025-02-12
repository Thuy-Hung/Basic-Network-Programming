using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClSvwithFile : Form
    {
        public ClSvwithFile()
        {
            InitializeComponent();
        }

        private void iconServer_Click(object sender, EventArgs e)
        {
            FileContent.F_Server sv = new FileContent.F_Server();
            sv.Show();
        }

        private void iconClient_Click(object sender, EventArgs e)
        {
            FileContent.F_Client cl = new FileContent.F_Client();
            cl.Show();
        }
    }
}
