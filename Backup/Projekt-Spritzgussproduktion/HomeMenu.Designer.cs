using System.ComponentModel;

namespace Projekt_Spritzgussproduktion
{
    partial class HomeMenu
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
            this.btnAmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuftragErstell = new System.Windows.Forms.Button();
            this.btnAuftragsstatus = new System.Windows.Forms.Button();
            this.btnLieferscheine = new System.Windows.Forms.Button();
            this.btnUserVerw = new System.Windows.Forms.Button();
            this.btnMitVerw = new System.Windows.Forms.Button();
            this.btnRohVerw = new System.Windows.Forms.Button();
            this.btnRechnVerw = new System.Windows.Forms.Button();
            this.btnProdVerw = new System.Windows.Forms.Button();
            this.btnAuftrVerw = new System.Windows.Forms.Button();
            this.btnKunVerw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmin
            // 
            this.btnAmin.Location = new System.Drawing.Point(846, 531);
            this.btnAmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAmin.Name = "btnAmin";
            this.btnAmin.Size = new System.Drawing.Size(194, 42);
            this.btnAmin.TabIndex = 22;
            this.btnAmin.Text = "Administrationstools";
            this.btnAmin.UseVisualStyleBackColor = true;
            this.btnAmin.Click += new System.EventHandler(this.btnAmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(846, 632);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 42);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuftragErstell
            // 
            this.btnAuftragErstell.Location = new System.Drawing.Point(838, 91);
            this.btnAuftragErstell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAuftragErstell.Name = "btnAuftragErstell";
            this.btnAuftragErstell.Size = new System.Drawing.Size(194, 42);
            this.btnAuftragErstell.TabIndex = 20;
            this.btnAuftragErstell.Text = "Auftrag Erstellen";
            this.btnAuftragErstell.UseVisualStyleBackColor = true;
            // 
            // btnAuftragsstatus
            // 
            this.btnAuftragsstatus.Location = new System.Drawing.Point(838, 18);
            this.btnAuftragsstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAuftragsstatus.Name = "btnAuftragsstatus";
            this.btnAuftragsstatus.Size = new System.Drawing.Size(194, 63);
            this.btnAuftragsstatus.TabIndex = 19;
            this.btnAuftragsstatus.Text = "Auftragsstatus\r\nübersicht";
            this.btnAuftragsstatus.UseVisualStyleBackColor = true;
            this.btnAuftragsstatus.Click += new System.EventHandler(this.btnAuftragsstatus_Click);
            // 
            // btnLieferscheine
            // 
            this.btnLieferscheine.Location = new System.Drawing.Point(838, 142);
            this.btnLieferscheine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLieferscheine.Name = "btnLieferscheine";
            this.btnLieferscheine.Size = new System.Drawing.Size(194, 42);
            this.btnLieferscheine.TabIndex = 18;
            this.btnLieferscheine.Text = "Lieferscheine";
            this.btnLieferscheine.UseVisualStyleBackColor = true;
            this.btnLieferscheine.Click += new System.EventHandler(this.btnLieferscheine_Click);
            // 
            // btnUserVerw
            // 
            this.btnUserVerw.Location = new System.Drawing.Point(846, 582);
            this.btnUserVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUserVerw.Name = "btnUserVerw";
            this.btnUserVerw.Size = new System.Drawing.Size(194, 42);
            this.btnUserVerw.TabIndex = 17;
            this.btnUserVerw.Text = "Benutzereinstellungen";
            this.btnUserVerw.UseVisualStyleBackColor = true;
            this.btnUserVerw.Click += new System.EventHandler(this.btnUserVerw_Click);
            // 
            // btnMitVerw
            // 
            this.btnMitVerw.Location = new System.Drawing.Point(368, 440);
            this.btnMitVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMitVerw.Name = "btnMitVerw";
            this.btnMitVerw.Size = new System.Drawing.Size(204, 51);
            this.btnMitVerw.TabIndex = 16;
            this.btnMitVerw.Text = "Mitarbeiter Verwaltung";
            this.btnMitVerw.UseVisualStyleBackColor = true;
            this.btnMitVerw.Click += new System.EventHandler(this.btnMitVerw_Click);
            // 
            // btnRohVerw
            // 
            this.btnRohVerw.Location = new System.Drawing.Point(368, 320);
            this.btnRohVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRohVerw.Name = "btnRohVerw";
            this.btnRohVerw.Size = new System.Drawing.Size(204, 51);
            this.btnRohVerw.TabIndex = 15;
            this.btnRohVerw.Text = "Rohstoff Verwaltung";
            this.btnRohVerw.UseVisualStyleBackColor = true;
            this.btnRohVerw.Click += new System.EventHandler(this.btnRohVerw_Click);
            // 
            // btnRechnVerw
            // 
            this.btnRechnVerw.Location = new System.Drawing.Point(368, 380);
            this.btnRechnVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechnVerw.Name = "btnRechnVerw";
            this.btnRechnVerw.Size = new System.Drawing.Size(204, 51);
            this.btnRechnVerw.TabIndex = 14;
            this.btnRechnVerw.Text = "Rechnungs Verwaltung";
            this.btnRechnVerw.UseVisualStyleBackColor = true;
            this.btnRechnVerw.Click += new System.EventHandler(this.btnRechnVerw_Click);
            // 
            // btnProdVerw
            // 
            this.btnProdVerw.Location = new System.Drawing.Point(368, 260);
            this.btnProdVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdVerw.Name = "btnProdVerw";
            this.btnProdVerw.Size = new System.Drawing.Size(204, 51);
            this.btnProdVerw.TabIndex = 13;
            this.btnProdVerw.Text = "Produkt Verwaltung";
            this.btnProdVerw.UseVisualStyleBackColor = true;
            this.btnProdVerw.Click += new System.EventHandler(this.btnProdVerw_Click);
            // 
            // btnAuftrVerw
            // 
            this.btnAuftrVerw.Location = new System.Drawing.Point(368, 200);
            this.btnAuftrVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAuftrVerw.Name = "btnAuftrVerw";
            this.btnAuftrVerw.Size = new System.Drawing.Size(204, 51);
            this.btnAuftrVerw.TabIndex = 12;
            this.btnAuftrVerw.Text = "Auftrags Verwaltung";
            this.btnAuftrVerw.UseVisualStyleBackColor = true;
            this.btnAuftrVerw.Click += new System.EventHandler(this.btnAuftrVerw_Click);
            // 
            // btnKunVerw
            // 
            this.btnKunVerw.Location = new System.Drawing.Point(368, 140);
            this.btnKunVerw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKunVerw.Name = "btnKunVerw";
            this.btnKunVerw.Size = new System.Drawing.Size(204, 51);
            this.btnKunVerw.TabIndex = 23;
            this.btnKunVerw.Text = "Kunden Verwaltung";
            this.btnKunVerw.UseVisualStyleBackColor = true;
            this.btnKunVerw.Click += new System.EventHandler(this.btnKunVerw_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 692);
            this.Controls.Add(this.btnKunVerw);
            this.Controls.Add(this.btnAmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAuftragErstell);
            this.Controls.Add(this.btnAuftragsstatus);
            this.Controls.Add(this.btnLieferscheine);
            this.Controls.Add(this.btnUserVerw);
            this.Controls.Add(this.btnMitVerw);
            this.Controls.Add(this.btnRohVerw);
            this.Controls.Add(this.btnRechnVerw);
            this.Controls.Add(this.btnProdVerw);
            this.Controls.Add(this.btnAuftrVerw);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeMenu";
            this.Text = "HomeMenu";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuftragErstell;
        private System.Windows.Forms.Button btnAuftragsstatus;
        private System.Windows.Forms.Button btnLieferscheine;
        private System.Windows.Forms.Button btnUserVerw;
        private System.Windows.Forms.Button btnMitVerw;
        private System.Windows.Forms.Button btnRohVerw;
        private System.Windows.Forms.Button btnRechnVerw;
        private System.Windows.Forms.Button btnProdVerw;
        private System.Windows.Forms.Button btnAuftrVerw;

        #endregion

        private System.Windows.Forms.Button btnKunVerw;
    }
}