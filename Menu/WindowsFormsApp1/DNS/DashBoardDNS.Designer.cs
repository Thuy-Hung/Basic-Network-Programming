namespace WindowsFormsApp1.DNS
{
    partial class DashBoardDNS
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
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Giải Đáp Tên Miền";
            // 
            // btn_server
            // 
            this.btn_server.BackColor = System.Drawing.Color.Black;
            this.btn_server.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_server.ForeColor = System.Drawing.Color.White;
            this.btn_server.Location = new System.Drawing.Point(70, 118);
            this.btn_server.Margin = new System.Windows.Forms.Padding(2);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(218, 48);
            this.btn_server.TabIndex = 11;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = false;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.Black;
            this.btn_client.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Location = new System.Drawing.Point(70, 219);
            this.btn_client.Margin = new System.Windows.Forms.Padding(2);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(218, 48);
            this.btn_client.TabIndex = 12;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // DashBoardDNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 349);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.label1);
            this.Name = "DashBoardDNS";
            this.Text = "Giải đáp tên miền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_client;
    }
}