using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Mail
{
    public partial class SendMail : Form
    {
        public SendMail(string account, string pass, bool isreply, string toe = "", string messid = "-1", string subjr = "")
        {
            InitializeComponent();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate(account, pass);

            from.Text = account;
            from.Enabled = false;
            if (isreply)
            {
                this.Text = "Reply Mail";
                to.Text = toe;
                mailto = toe.Split('<')[1].Split('>')[0].Trim();
            }
            idmess = messid;
            subj = subjr;
        }
        SmtpClient smtpClient = new SmtpClient();
        string mailto = "", idmess, subj;

        private void SendMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            smtpClient.Disconnect(true);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name.Text, from.Text));
            if (mailto == "")
            {
                mailto = to.Text;
            }
            message.To.Add(new MailboxAddress("", mailto));
            message.Subject = subject.Text;
            if (idmess != "-1")
            {
                subject.ReadOnly = true;
                message.MessageId = idmess;
                message.Subject = subj;
            }
            string k = "plain";
            var builder = new BodyBuilder();
            if (checkBox1.Checked)
            {
                builder.HtmlBody = content.Text; k = "HTML";
            }
            else
            {
                builder.TextBody = content.Text;
            }
            if (file_link.Text != "")
            {
                builder.Attachments.Add(file_link.Text);
            }
            message.Body = new TextPart(k);
            message.Body = builder.ToMessageBody();
            smtpClient.Send(message);

            MessageBox.Show("Finished sending mail!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file_link.Text = ofd.FileName;
            }
        }
    }
}
