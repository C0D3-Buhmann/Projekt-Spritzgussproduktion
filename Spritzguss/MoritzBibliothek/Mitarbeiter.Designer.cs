using System.ComponentModel;

namespace MoritzBibliothek
{
    partial class Mitarbeiter
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMitEmail = new System.Windows.Forms.TextBox();
            this.txtKundPosition = new System.Windows.Forms.TextBox();
            this.txtKundAbteilung = new System.Windows.Forms.TextBox();
            this.txtMitUserName = new System.Windows.Forms.TextBox();
            this.txtMitUUID = new System.Windows.Forms.TextBox();
            this.btnConfirmMitarb = new System.Windows.Forms.Button();
            this.lblMitarb = new System.Windows.Forms.Label();
            this.cBoxMitarb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(3, 135);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.ReadOnly = true;
            this.txtPasswd.Size = new System.Drawing.Size(110, 20);
            this.txtPasswd.TabIndex = 109;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(3, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 20);
            this.label16.TabIndex = 108;
            this.label16.Text = "Password";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(3, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 106;
            this.label13.Text = "ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(132, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 105;
            this.label14.Text = "Username";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(3, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 104;
            this.label15.Text = "Abteilung";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTel.Location = new System.Drawing.Point(132, 66);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(110, 20);
            this.lblTel.TabIndex = 103;
            this.lblTel.Text = "Email";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(132, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 102;
            this.label17.Text = "Position";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMitEmail
            // 
            this.txtMitEmail.Location = new System.Drawing.Point(132, 89);
            this.txtMitEmail.Name = "txtMitEmail";
            this.txtMitEmail.ReadOnly = true;
            this.txtMitEmail.Size = new System.Drawing.Size(110, 20);
            this.txtMitEmail.TabIndex = 101;
            this.txtMitEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKundPosition
            // 
            this.txtKundPosition.Location = new System.Drawing.Point(132, 182);
            this.txtKundPosition.Name = "txtKundPosition";
            this.txtKundPosition.ReadOnly = true;
            this.txtKundPosition.Size = new System.Drawing.Size(110, 20);
            this.txtKundPosition.TabIndex = 100;
            this.txtKundPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKundAbteilung
            // 
            this.txtKundAbteilung.Location = new System.Drawing.Point(3, 181);
            this.txtKundAbteilung.Name = "txtKundAbteilung";
            this.txtKundAbteilung.ReadOnly = true;
            this.txtKundAbteilung.Size = new System.Drawing.Size(110, 20);
            this.txtKundAbteilung.TabIndex = 99;
            this.txtKundAbteilung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMitUserName
            // 
            this.txtMitUserName.Location = new System.Drawing.Point(132, 135);
            this.txtMitUserName.Name = "txtMitUserName";
            this.txtMitUserName.ReadOnly = true;
            this.txtMitUserName.Size = new System.Drawing.Size(110, 20);
            this.txtMitUserName.TabIndex = 98;
            this.txtMitUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMitUUID
            // 
            this.txtMitUUID.Location = new System.Drawing.Point(3, 89);
            this.txtMitUUID.Name = "txtMitUUID";
            this.txtMitUUID.ReadOnly = true;
            this.txtMitUUID.Size = new System.Drawing.Size(110, 20);
            this.txtMitUUID.TabIndex = 97;
            this.txtMitUUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirmMitarb
            // 
            this.btnConfirmMitarb.Enabled = false;
            this.btnConfirmMitarb.Location = new System.Drawing.Point(174, 208);
            this.btnConfirmMitarb.Name = "btnConfirmMitarb";
            this.btnConfirmMitarb.Size = new System.Drawing.Size(68, 29);
            this.btnConfirmMitarb.TabIndex = 96;
            this.btnConfirmMitarb.Text = "Bestätigen";
            this.btnConfirmMitarb.UseVisualStyleBackColor = true;
            // 
            // lblMitarb
            // 
            this.lblMitarb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMitarb.Location = new System.Drawing.Point(3, 20);
            this.lblMitarb.Name = "lblMitarb";
            this.lblMitarb.Size = new System.Drawing.Size(239, 20);
            this.lblMitarb.TabIndex = 95;
            this.lblMitarb.Text = "Mitarbeiter";
            this.lblMitarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxMitarb
            // 
            this.cBoxMitarb.Enabled = false;
            this.cBoxMitarb.FormattingEnabled = true;
            this.cBoxMitarb.Location = new System.Drawing.Point(3, 42);
            this.cBoxMitarb.Name = "cBoxMitarb";
            this.cBoxMitarb.Size = new System.Drawing.Size(239, 21);
            this.cBoxMitarb.TabIndex = 94;
            // 
            // Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMitEmail);
            this.Controls.Add(this.txtKundPosition);
            this.Controls.Add(this.txtKundAbteilung);
            this.Controls.Add(this.txtMitUserName);
            this.Controls.Add(this.txtMitUUID);
            this.Controls.Add(this.btnConfirmMitarb);
            this.Controls.Add(this.lblMitarb);
            this.Controls.Add(this.cBoxMitarb);
            this.Name = "Mitarbeiter";
            this.Size = new System.Drawing.Size(254, 248);
            this.Load += new System.EventHandler(this.Mitarbeiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMitEmail;
        private System.Windows.Forms.TextBox txtKundPosition;
        private System.Windows.Forms.TextBox txtKundAbteilung;
        private System.Windows.Forms.TextBox txtMitUserName;
        private System.Windows.Forms.TextBox txtMitUUID;
        public System.Windows.Forms.Button btnConfirmMitarb;
        private System.Windows.Forms.Label lblMitarb;
        public System.Windows.Forms.ComboBox cBoxMitarb;

        #endregion
    }
}