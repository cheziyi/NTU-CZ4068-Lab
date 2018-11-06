namespace WebGoatFuzzer
{
    partial class Form1
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
            this.wbWebGoat = new System.Windows.Forms.WebBrowser();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMigitation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wbWebGoat
            // 
            this.wbWebGoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbWebGoat.Location = new System.Drawing.Point(0, 132);
            this.wbWebGoat.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbWebGoat.Name = "wbWebGoat";
            this.wbWebGoat.Size = new System.Drawing.Size(584, 429);
            this.wbWebGoat.TabIndex = 3;
            this.wbWebGoat.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbWebGoat_Navigated);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(12, 12);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(258, 23);
            this.btnAdvanced.TabIndex = 4;
            this.btnAdvanced.Text = "SQL Injection (advanced) 5";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(357, 14);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(357, 47);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(215, 20);
            this.txtIp.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Address:";
            // 
            // btnMigitation
            // 
            this.btnMigitation.Location = new System.Drawing.Point(12, 45);
            this.btnMigitation.Name = "btnMigitation";
            this.btnMigitation.Size = new System.Drawing.Size(258, 23);
            this.btnMigitation.TabIndex = 7;
            this.btnMigitation.Text = "SQL Injection (mitigation) 8";
            this.btnMigitation.UseVisualStyleBackColor = true;
            this.btnMigitation.Click += new System.EventHandler(this.btnMigitation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(50, 86);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(522, 40);
            this.txtUrl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMigitation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.wbWebGoat);
            this.Name = "Form1";
            this.Text = "WebGoat Fuzzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wbWebGoat;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMigitation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

