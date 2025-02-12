using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WindowsFormsApp1.Mail
{
    public partial class w : Form
    {
        public w(string html, string from, string to, string sub, string acc, string pass, string id = "-1")
        {
            InitializeComponent();

            text_from.Text = from;
            text_to.Text = to;
            this.Text = sub;
            frome = to; toe = from;
            pas = pass; ac = acc;
            idmess = id;

            InitBrowser(html);
        }
        private async Task initizated()
        {
            
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser(string html)
        {
            await initizated();
            webView21.CoreWebView2.NavigateToString(html);
        }
        string frome, toe, ac, pas, idmess;

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            SendMail sm = new SendMail(ac, pas, true, toe, idmess, this.Text);
            sm.Show();
        }
    }
}
