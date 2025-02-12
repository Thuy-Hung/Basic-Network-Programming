namespace WindowsFormsApp1
{
    partial class ClSvwithFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconClient = new FontAwesome.Sharp.IconButton();
            this.iconServer = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconClient);
            this.panel1.Controls.Add(this.iconServer);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đề tài 7";
            // 
            // iconClient
            // 
            this.iconClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconClient.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconClient.IconColor = System.Drawing.Color.Black;
            this.iconClient.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconClient.Location = new System.Drawing.Point(486, 280);
            this.iconClient.Name = "iconClient";
            this.iconClient.Size = new System.Drawing.Size(129, 97);
            this.iconClient.TabIndex = 3;
            this.iconClient.Text = "Client";
            this.iconClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconClient.UseVisualStyleBackColor = true;
            this.iconClient.Click += new System.EventHandler(this.iconClient_Click);
            // 
            // iconServer
            // 
            this.iconServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconServer.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.iconServer.IconColor = System.Drawing.Color.Black;
            this.iconServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconServer.Location = new System.Drawing.Point(184, 280);
            this.iconServer.Name = "iconServer";
            this.iconServer.Size = new System.Drawing.Size(129, 97);
            this.iconServer.TabIndex = 2;
            this.iconServer.Text = "Server";
            this.iconServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconServer.UseVisualStyleBackColor = true;
            this.iconServer.Click += new System.EventHandler(this.iconServer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(69, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(697, 174);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Viết chương trình Client/Server. Khi Client gửi đường\ndẫn của tập tin nằm trên má" +
    "y server thì server gửi trả\ncho Client nội dung của tập tin đó\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClSvwithFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ClSvwithFile";
            this.Text = "Send File Content";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconClient;
        private FontAwesome.Sharp.IconButton iconServer;
        private System.Windows.Forms.TextBox textBox1;
    }
}