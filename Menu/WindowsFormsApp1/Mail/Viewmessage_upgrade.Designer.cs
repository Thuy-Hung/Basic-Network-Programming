namespace Lab05
{
    partial class Viewmessage_upgrade
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textto = new TextBox();
            text_from = new TextBox();
            label = new Label();
            lable = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textto);
            groupBox1.Controls.Add(text_from);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(lable);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 133, 254);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(591, 33);
            button1.Name = "button1";
            button1.Size = new Size(144, 62);
            button1.TabIndex = 4;
            button1.Text = "Reply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textto
            // 
            textto.BackColor = SystemColors.Control;
            textto.BorderStyle = BorderStyle.None;
            textto.Location = new Point(100, 112);
            textto.Name = "textto";
            textto.ReadOnly = true;
            textto.Size = new Size(490, 27);
            textto.TabIndex = 3;
            // 
            // text_from
            // 
            text_from.BackColor = SystemColors.Control;
            text_from.BorderStyle = BorderStyle.None;
            text_from.Location = new Point(100, 27);
            text_from.Name = "text_from";
            text_from.ReadOnly = true;
            text_from.Size = new Size(462, 27);
            text_from.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(21, 115);
            label.Name = "label";
            label.Size = new Size(37, 28);
            label.TabIndex = 1;
            label.Text = "to:";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lable.Location = new Point(21, 30);
            lable.Name = "lable";
            lable.Size = new Size(65, 28);
            lable.TabIndex = 0;
            lable.Text = "From:";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 177);
            webView21.Name = "webView21";
            webView21.Size = new Size(747, 524);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            // 
            // Viewmessage_upgrade
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 701);
            Controls.Add(webView21);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Viewmessage_upgrade";
            Text = "Viewmessage_upgrade";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textto;
        private TextBox text_from;
        private Label label;
        private Label lable;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}