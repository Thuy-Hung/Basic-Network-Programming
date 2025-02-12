namespace WindowsFormsApp1.Mail
{
    partial class w
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
            this.text_from = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.btn_Reply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.text_to = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // text_from
            // 
            this.text_from.BackColor = System.Drawing.Color.White;
            this.text_from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_from.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_from.Location = new System.Drawing.Point(112, 44);
            this.text_from.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_from.Name = "text_from";
            this.text_from.ReadOnly = true;
            this.text_from.Size = new System.Drawing.Size(472, 38);
            this.text_from.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(140, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(472, 38);
            this.textBox2.TabIndex = 1;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.White;
            this.text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(14, 51);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(76, 30);
            this.text.TabIndex = 2;
            this.text.Text = "From :";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.BackColor = System.Drawing.Color.White;
            this.to.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(17, 92);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(48, 30);
            this.to.TabIndex = 3;
            this.to.Text = "To :";
            // 
            // btn_Reply
            // 
            this.btn_Reply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(254)))));
            this.btn_Reply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reply.ForeColor = System.Drawing.Color.White;
            this.btn_Reply.Location = new System.Drawing.Point(590, 51);
            this.btn_Reply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reply.Name = "btn_Reply";
            this.btn_Reply.Size = new System.Drawing.Size(145, 59);
            this.btn_Reply.TabIndex = 4;
            this.btn_Reply.Text = "Reply";
            this.btn_Reply.UseVisualStyleBackColor = false;
            this.btn_Reply.Click += new System.EventHandler(this.btn_Reply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.text_to);
            this.groupBox1.Controls.Add(this.webView21);
            this.groupBox1.Controls.Add(this.btn_Reply);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(782, 664);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webView21.Location = new System.Drawing.Point(3, 146);
            this.webView21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(776, 514);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // text_to
            // 
            this.text_to.BackColor = System.Drawing.Color.White;
            this.text_to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_to.Location = new System.Drawing.Point(112, 92);
            this.text_to.Name = "text_to";
            this.text_to.ReadOnly = true;
            this.text_to.Size = new System.Drawing.Size(472, 32);
            this.text_to.TabIndex = 6;
            // 
            // w
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 664);
            this.Controls.Add(this.to);
            this.Controls.Add(this.text);
            this.Controls.Add(this.text_from);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "w";
            this.Text = "ViewMessage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_from;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Button btn_Reply;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TextBox text_to;
    }
}