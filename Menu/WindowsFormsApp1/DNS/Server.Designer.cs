namespace WindowsFormsApp1.DNS
{
    partial class Server
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.Client_list = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(321, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập port";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.Black;
            this.btn_disconnect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_disconnect.Location = new System.Drawing.Point(529, 129);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(166, 65);
            this.btn_disconnect.TabIndex = 10;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // ip_tb
            // 
            this.ip_tb.BackColor = System.Drawing.SystemColors.Menu;
            this.ip_tb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(43, 157);
            this.ip_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(242, 39);
            this.ip_tb.TabIndex = 11;
            // 
            // port_tb
            // 
            this.port_tb.BackColor = System.Drawing.SystemColors.Menu;
            this.port_tb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(321, 157);
            this.port_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(169, 39);
            this.port_tb.TabIndex = 5;
            // 
            // Client_list
            // 
            this.Client_list.BackColor = System.Drawing.SystemColors.Menu;
            this.Client_list.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_list.FormattingEnabled = true;
            this.Client_list.ItemHeight = 31;
            this.Client_list.Location = new System.Drawing.Point(43, 242);
            this.Client_list.Margin = new System.Windows.Forms.Padding(4);
            this.Client_list.Name = "Client_list";
            this.Client_list.Size = new System.Drawing.Size(447, 190);
            this.Client_list.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._339020882_1044641246923428_1868206466218917169_n;
            this.pictureBox1.Location = new System.Drawing.Point(529, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Listen
            // 
            this.btn_Listen.BackColor = System.Drawing.Color.Black;
            this.btn_Listen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Listen.ForeColor = System.Drawing.Color.White;
            this.btn_Listen.Location = new System.Drawing.Point(529, 129);
            this.btn_Listen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(166, 65);
            this.btn_Listen.TabIndex = 14;
            this.btn_Listen.Text = "Kết nối";
            this.btn_Listen.UseVisualStyleBackColor = false;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 494);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Client_list);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.ip_tb);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox ip_tb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.ListBox Client_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Listen;
    }
}