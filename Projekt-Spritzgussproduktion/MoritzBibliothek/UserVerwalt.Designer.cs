using System.ComponentModel;

namespace MoritzBibliothek
{
    partial class UserVerwalt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.cBoxUser = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPasswd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxUser
            // 
            this.cBoxUser.FormattingEnabled = true;
            this.cBoxUser.Location = new System.Drawing.Point(12, 11);
            this.cBoxUser.Name = "cBoxUser";
            this.cBoxUser.Size = new System.Drawing.Size(123, 21);
            this.cBoxUser.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 21);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 21);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 21);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Enabled = false;
            this.txtPasswd.Location = new System.Drawing.Point(12, 64);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(123, 20);
            this.txtPasswd.TabIndex = 7;
            this.txtPasswd.Text = "Password";
            this.txtPasswd.Visible = false;
            this.txtPasswd.Click += new System.EventHandler(this.txtPasswd_Click);
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            // 
            // txtUName
            // 
            this.txtUName.Enabled = false;
            this.txtUName.Location = new System.Drawing.Point(12, 38);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(123, 20);
            this.txtUName.TabIndex = 6;
            this.txtUName.Text = "Username";
            this.txtUName.Visible = false;
            this.txtUName.Click += new System.EventHandler(this.txtUName_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(141, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPasswd2
            // 
            this.txtPasswd2.Enabled = false;
            this.txtPasswd2.Location = new System.Drawing.Point(12, 90);
            this.txtPasswd2.Name = "txtPasswd2";
            this.txtPasswd2.Size = new System.Drawing.Size(123, 20);
            this.txtPasswd2.TabIndex = 9;
            this.txtPasswd2.Text = "Confirm Password";
            this.txtPasswd2.Visible = false;
            this.txtPasswd2.Click += new System.EventHandler(this.txtPasswd2_Click);
            this.txtPasswd2.TextChanged += new System.EventHandler(this.txtPasswd2_TextChanged);
            // 
            // UserVerwalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(271, 123);
            this.Controls.Add(this.txtPasswd2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cBoxUser);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UserVerwalt";
            this.Text = "User Verwaltung";
            this.Load += new System.EventHandler(this.UserVerwalt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPasswd2;

        private System.Windows.Forms.Button btnCreate;

        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUName;

        private System.Windows.Forms.ComboBox cBoxUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        #endregion
    }
}