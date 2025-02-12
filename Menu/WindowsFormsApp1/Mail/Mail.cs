using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Mail
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            Set_status(true);
            account.Text = "lory265265@gmail.com";
            password.Text = "vaoalyvahsaclalq";
            dataGridView1.RowTemplate.Height = 41;
        }
        ImapClient client = new ImapClient();
        int head = 1, tail = 20;
        private void Set_status(bool islogin)
        {
            if (islogin)
            {
                pn_login.Visible = true;
                pn_main.Visible = false;
                this.Height = 745;
                pn_login.Dock = DockStyle.Fill;
                pn_main.Dock = DockStyle.None;
                this.Width = 480;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                pn_login.Visible = false;
                pn_main.Visible = true;
                this.Height = 642;
                this.Width = 1008;
                pn_main.Dock = DockStyle.Fill;
                pn_login.Dock = DockStyle.None;

            }
        }
        private void List_mail()
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            page.Text = "1-20 of " + inbox.Count.ToString();
            for (int i = inbox.Count - 1; i >= inbox.Count - 20; i--)
            {
                var message = inbox.GetMessage(i);

                dataGridView1.Rows.Add(message.From, message.Subject, message.Date);
            }
            inbox.Close();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(account.Text, password.Text);
                dataGridView1.Rows.Clear();
                account_tb.Text = account.Text;
                List_mail();
                Set_status(false);
            }
            catch (Exception ex)
            {
                client.Disconnect(true);
                client = new ImapClient();
                MessageBox.Show(ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendMail sm = new SendMail(account.Text, password.Text, false);
            sm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            btn_back.Visible = true;
            btn_next.Visible = true;
            dataGridView1.Rows.Clear();
            List_mail();
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            btn_back.Visible = false;
            btn_next.Visible = false;
            page.Text = "";
            dataGridView2.Rows.Clear();
            var sent = client.GetFolder(SpecialFolder.Sent);
            sent.Open(FolderAccess.ReadOnly);
            var query = SearchQuery.SentSince(DateTime.Now.AddDays(-7));
            var uids = sent.Search(query);
            foreach (var uid in uids)
            {
                var message = sent.GetMessage(uid);
                dataGridView2.Rows.Add(message.To, message.Subject, message.Date);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            Set_status(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (head - 20 >= 1)
            {
                var inbox = client.Inbox;
                head -= 20;
                tail -= 20;
                dataGridView1.Rows.Clear();
                inbox.Open(FolderAccess.ReadOnly);
                page.Text = head.ToString() + "-" + tail.ToString() + " of " + inbox.Count.ToString();
                for (int i = (int)(inbox.Count - head); i >= inbox.Count - tail; i--)
                {
                    var message = inbox.GetMessage(i);
                    dataGridView1.Rows.Add(message.From, message.Subject, message.Date);
                }
                inbox.Close();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var inbox = client.Inbox;
            if (tail + 20 <= inbox.Count)
            {
                head += 20;
                tail += 20;
                dataGridView1.Rows.Clear();

                inbox.Open(FolderAccess.ReadOnly);
                page.Text = head.ToString() + "-" + tail.ToString() + " of " + inbox.Count.ToString();
                for (int i = (int)(inbox.Count - head); i >= inbox.Count - tail; i--)
                {
                    var message = inbox.GetMessage(i);
                    dataGridView1.Rows.Add(message.From, message.Subject, message.Date);
                }
                inbox.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var message = inbox.GetMessage(inbox.Count - e.RowIndex - 1);
            var body = message.BodyParts.OfType<TextPart>().FirstOrDefault(x => x.IsHtml);
            w veu = new w(body.Text, message.From.ToString(), account.Text, message.Subject, account.Text, password.Text, message.MessageId);
            veu.Show();
            inbox.Close();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var sent = client.GetFolder(SpecialFolder.Sent);
            sent.Open(FolderAccess.ReadOnly);
            var query = SearchQuery.SentSince(DateTime.Now.AddDays(-7));
            var uids = sent.Search(query);
            var message = sent.GetMessage(uids.Count - e.RowIndex - 1);
            var body = message.BodyParts.OfType<TextPart>().FirstOrDefault(x => x.IsHtml);
            w veu = new w(body.Text, message.From.ToString(), account.Text, message.Subject, account.Text, password.Text);
            veu.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked) { password.PasswordChar = '\0'; }
            else { password.PasswordChar = '*'; }
        }
    }
}
