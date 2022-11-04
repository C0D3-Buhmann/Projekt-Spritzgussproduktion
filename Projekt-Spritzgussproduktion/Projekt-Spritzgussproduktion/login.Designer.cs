namespace Projekt_Spritzgussproduktion
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 99);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(10, 37);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(103, 20);
            this.txtUName.TabIndex = 1;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(10, 85);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(103, 20);
            this.txtPasswd.TabIndex = 2;
            this.txtPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswd_KeyDown);
            // 
            // lblUName
            // 
            this.lblUName.Location = new System.Drawing.Point(10, 12);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(103, 22);
            this.lblUName.TabIndex = 3;
            this.lblUName.Text = "Username";
            this.lblUName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswd
            // 
            this.lblPasswd.Location = new System.Drawing.Point(10, 60);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(103, 22);
            this.lblPasswd.TabIndex = 4;
            this.lblPasswd.Text = "Password";
            this.lblPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 124);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPasswd;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblUName;

        #endregion
    }
}