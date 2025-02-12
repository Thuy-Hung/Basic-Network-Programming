namespace WindowsFormsApp1.DNS
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tenmien = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.checkBoxipv4 = new System.Windows.Forms.CheckBox();
            this.checkBoxipv6 = new System.Windows.Forms.CheckBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.port_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ip_input = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chương Trình Giải Đáp Tên Miền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tên miền";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.tenmien);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.btn_quit);
            this.panel_main.Controls.Add(this.btn_find);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.Result);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.checkBoxipv4);
            this.panel_main.Controls.Add(this.checkBoxipv6);
            this.panel_main.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(2, 10);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(576, 463);
            this.panel_main.TabIndex = 3;
            // 
            // tenmien
            // 
            this.tenmien.BackColor = System.Drawing.SystemColors.Menu;
            this.tenmien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenmien.Location = new System.Drawing.Point(184, 108);
            this.tenmien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tenmien.Name = "tenmien";
            this.tenmien.Size = new System.Drawing.Size(360, 39);
            this.tenmien.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._339020882_1044641246923428_1868206466218917169_n;
            this.pictureBox1.Location = new System.Drawing.Point(409, 269);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Black;
            this.btn_quit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(409, 214);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(135, 47);
            this.btn_quit.TabIndex = 9;
            this.btn_quit.Text = "Thoát";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Black;
            this.btn_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(409, 154);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(135, 47);
            this.btn_find.TabIndex = 11;
            this.btn_find.Text = "Tra";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.Menu;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 31;
            this.Result.Location = new System.Drawing.Point(24, 214);
            this.Result.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(370, 190);
            this.Result.TabIndex = 8;
            // 
            // checkBoxipv4
            // 
            this.checkBoxipv4.AutoSize = true;
            this.checkBoxipv4.Location = new System.Drawing.Point(25, 163);
            this.checkBoxipv4.Name = "checkBoxipv4";
            this.checkBoxipv4.Size = new System.Drawing.Size(68, 29);
            this.checkBoxipv4.TabIndex = 5;
            this.checkBoxipv4.Text = "IPv4";
            this.checkBoxipv4.UseVisualStyleBackColor = true;
            // 
            // checkBoxipv6
            // 
            this.checkBoxipv6.AutoSize = true;
            this.checkBoxipv6.Location = new System.Drawing.Point(151, 163);
            this.checkBoxipv6.Name = "checkBoxipv6";
            this.checkBoxipv6.Size = new System.Drawing.Size(68, 29);
            this.checkBoxipv6.TabIndex = 6;
            this.checkBoxipv6.Text = "IPv6";
            this.checkBoxipv6.UseVisualStyleBackColor = true;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.White;
            this.panel_login.Controls.Add(this.groupBox2);
            this.panel_login.Controls.Add(this.groupBox1);
            this.panel_login.Controls.Add(this.btn_connect);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.Location = new System.Drawing.Point(655, 59);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(337, 326);
            this.panel_login.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.port_input);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 58);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // port_input
            // 
            this.port_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_input.Location = new System.Drawing.Point(5, 30);
            this.port_input.Name = "port_input";
            this.port_input.Size = new System.Drawing.Size(250, 32);
            this.port_input.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ip_input);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // ip_input
            // 
            this.ip_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_input.Location = new System.Drawing.Point(5, 27);
            this.ip_input.Name = "ip_input";
            this.ip_input.Size = new System.Drawing.Size(247, 32);
            this.ip_input.TabIndex = 13;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Black;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(58, 246);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(213, 42);
            this.btn_connect.TabIndex = 10;
            this.btn_connect.Text = "Kết nối";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 535);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_main);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.CheckBox checkBoxipv4;
        private System.Windows.Forms.CheckBox checkBoxipv6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tenmien;
        private System.Windows.Forms.TextBox ip_input;
        private System.Windows.Forms.TextBox port_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}