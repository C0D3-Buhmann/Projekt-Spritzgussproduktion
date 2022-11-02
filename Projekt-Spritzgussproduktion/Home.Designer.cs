using System.ComponentModel;

namespace Projekt_Spritzgussproduktion
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Auftragsstatus = new System.Windows.Forms.Button();
            this.btnLieferscheine = new System.Windows.Forms.Button();
            this.btnUserVerw = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Auftrags Verwaltung";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Produkt Verwaltung";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rechnungs Verwaltung";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(296, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rohstoff Verwaltung";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Mitarbeiter Verwaltung";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(613, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "Auftrag Erstellen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Auftragsstatus
            // 
            this.Auftragsstatus.Location = new System.Drawing.Point(613, 12);
            this.Auftragsstatus.Name = "Auftragsstatus";
            this.Auftragsstatus.Size = new System.Drawing.Size(103, 41);
            this.Auftragsstatus.TabIndex = 7;
            this.Auftragsstatus.Text = "Auftragsstatus\r\nübersicht";
            this.Auftragsstatus.UseVisualStyleBackColor = true;
            // 
            // btnLieferscheine
            // 
            this.btnLieferscheine.Location = new System.Drawing.Point(613, 92);
            this.btnLieferscheine.Name = "btnLieferscheine";
            this.btnLieferscheine.Size = new System.Drawing.Size(103, 27);
            this.btnLieferscheine.TabIndex = 6;
            this.btnLieferscheine.Text = "Lieferscheine";
            this.btnLieferscheine.UseVisualStyleBackColor = true;
            // 
            // btnUserVerw
            // 
            this.btnUserVerw.Location = new System.Drawing.Point(618, 378);
            this.btnUserVerw.Name = "btnUserVerw";
            this.btnUserVerw.Size = new System.Drawing.Size(103, 27);
            this.btnUserVerw.TabIndex = 5;
            this.btnUserVerw.Text = "Benutzerübersicht";
            this.btnUserVerw.UseVisualStyleBackColor = true;
            this.btnUserVerw.Click += new System.EventHandler(this.btnUserVerw_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(618, 411);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 27);
            this.button10.TabIndex = 10;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(618, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 27);
            this.button6.TabIndex = 11;
            this.button6.Text = "Administrationstools";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Auftragsstatus);
            this.Controls.Add(this.btnLieferscheine);
            this.Controls.Add(this.btnUserVerw);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button10;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Auftragsstatus;
        private System.Windows.Forms.Button btnLieferscheine;
        private System.Windows.Forms.Button btnUserVerw;

        #endregion
    }
}