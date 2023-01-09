using System.ComponentModel;

namespace Projekt_Spritzgussproduktion
{
    partial class AuftragsVerwalt
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
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxSchritt = new System.Windows.Forms.ComboBox();
            this.txtVerbGes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerb = new System.Windows.Forms.TextBox();
            this.lBoxRoh = new System.Windows.Forms.ListBox();
            this.btnProdVerw = new System.Windows.Forms.Button();
            this.btnRohVerw = new System.Windows.Forms.Button();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblMenge = new System.Windows.Forms.Label();
            this.cBoxAutrag = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.nUDMenge = new System.Windows.Forms.NumericUpDown();
            this.btnAuftrBuchen = new System.Windows.Forms.Button();
            this.btnAuftrNeu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAuftr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lBoxCompany = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxKont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxProd = new System.Windows.Forms.ComboBox();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.cBoxSchritt);
            this.groupInfo.Controls.Add(this.txtVerbGes);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.txtVerb);
            this.groupInfo.Controls.Add(this.lBoxRoh);
            this.groupInfo.Location = new System.Drawing.Point(262, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(425, 339);
            this.groupInfo.TabIndex = 17;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Info";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(295, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Gesammt Verbrauch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxSchritt
            // 
            this.cBoxSchritt.FormattingEnabled = true;
            this.cBoxSchritt.Location = new System.Drawing.Point(6, 35);
            this.cBoxSchritt.Name = "cBoxSchritt";
            this.cBoxSchritt.Size = new System.Drawing.Size(59, 21);
            this.cBoxSchritt.TabIndex = 32;
            // 
            // txtVerbGes
            // 
            this.txtVerbGes.Location = new System.Drawing.Point(295, 198);
            this.txtVerbGes.Name = "txtVerbGes";
            this.txtVerbGes.Size = new System.Drawing.Size(124, 20);
            this.txtVerbGes.TabIndex = 11;
            this.txtVerbGes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(295, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Verbauch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVerb
            // 
            this.txtVerb.Location = new System.Drawing.Point(295, 152);
            this.txtVerb.Name = "txtVerb";
            this.txtVerb.Size = new System.Drawing.Size(124, 20);
            this.txtVerb.TabIndex = 9;
            this.txtVerb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBoxRoh
            // 
            this.lBoxRoh.FormattingEnabled = true;
            this.lBoxRoh.Location = new System.Drawing.Point(71, 19);
            this.lBoxRoh.Name = "lBoxRoh";
            this.lBoxRoh.Size = new System.Drawing.Size(218, 303);
            this.lBoxRoh.TabIndex = 3;
            // 
            // btnProdVerw
            // 
            this.btnProdVerw.Location = new System.Drawing.Point(693, 12);
            this.btnProdVerw.Name = "btnProdVerw";
            this.btnProdVerw.Size = new System.Drawing.Size(110, 28);
            this.btnProdVerw.TabIndex = 15;
            this.btnProdVerw.Text = "Produktverwaltung";
            this.btnProdVerw.UseVisualStyleBackColor = true;
            // 
            // btnRohVerw
            // 
            this.btnRohVerw.Location = new System.Drawing.Point(693, 46);
            this.btnRohVerw.Name = "btnRohVerw";
            this.btnRohVerw.Size = new System.Drawing.Size(110, 28);
            this.btnRohVerw.TabIndex = 11;
            this.btnRohVerw.Text = "Rohstoffverwaltung";
            this.btnRohVerw.UseVisualStyleBackColor = true;
            // 
            // lblPreis
            // 
            this.lblPreis.Location = new System.Drawing.Point(173, 183);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(70, 20);
            this.lblPreis.TabIndex = 25;
            this.lblPreis.Text = "Preis";
            this.lblPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenge
            // 
            this.lblMenge.Location = new System.Drawing.Point(12, 183);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(70, 20);
            this.lblMenge.TabIndex = 22;
            this.lblMenge.Text = "Menge";
            this.lblMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxAutrag
            // 
            this.cBoxAutrag.FormattingEnabled = true;
            this.cBoxAutrag.Location = new System.Drawing.Point(88, 117);
            this.cBoxAutrag.Name = "cBoxAutrag";
            this.cBoxAutrag.Size = new System.Drawing.Size(79, 21);
            this.cBoxAutrag.TabIndex = 20;
            this.cBoxAutrag.TextChanged += new System.EventHandler(this.cBAutrag_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 209);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 28);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Ändern";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // nUDMenge
            // 
            this.nUDMenge.Location = new System.Drawing.Point(88, 183);
            this.nUDMenge.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMenge.Name = "nUDMenge";
            this.nUDMenge.ReadOnly = true;
            this.nUDMenge.Size = new System.Drawing.Size(79, 20);
            this.nUDMenge.TabIndex = 27;
            // 
            // btnAuftrBuchen
            // 
            this.btnAuftrBuchen.Enabled = false;
            this.btnAuftrBuchen.Location = new System.Drawing.Point(693, 287);
            this.btnAuftrBuchen.Name = "btnAuftrBuchen";
            this.btnAuftrBuchen.Size = new System.Drawing.Size(110, 28);
            this.btnAuftrBuchen.TabIndex = 28;
            this.btnAuftrBuchen.Text = "Auftrag Buchen";
            this.btnAuftrBuchen.UseVisualStyleBackColor = true;
            this.btnAuftrBuchen.Click += new System.EventHandler(this.btnAuftrBuchen_Click);
            // 
            // btnAuftrNeu
            // 
            this.btnAuftrNeu.Location = new System.Drawing.Point(12, 243);
            this.btnAuftrNeu.Name = "btnAuftrNeu";
            this.btnAuftrNeu.Size = new System.Drawing.Size(231, 28);
            this.btnAuftrNeu.TabIndex = 29;
            this.btnAuftrNeu.Text = "Neu Anlegen";
            this.btnAuftrNeu.UseVisualStyleBackColor = true;
            this.btnAuftrNeu.Click += new System.EventHandler(this.btnAuftrNeu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 28);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(693, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 27);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAuftr
            // 
            this.lblAuftr.Location = new System.Drawing.Point(12, 117);
            this.lblAuftr.Name = "lblAuftr";
            this.lblAuftr.Size = new System.Drawing.Size(70, 20);
            this.lblAuftr.TabIndex = 33;
            this.lblAuftr.Text = "Auftrag";
            this.lblAuftr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Produkt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 3);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(582, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 182);
            this.panel2.TabIndex = 16;
            // 
            // lBoxCompany
            // 
            this.lBoxCompany.FormattingEnabled = true;
            this.lBoxCompany.Location = new System.Drawing.Point(12, 32);
            this.lBoxCompany.Name = "lBoxCompany";
            this.lBoxCompany.Size = new System.Drawing.Size(115, 69);
            this.lBoxCompany.TabIndex = 46;
            this.lBoxCompany.SelectedIndexChanged += new System.EventHandler(this.lBoxCompany_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Unternehmen";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxKont
            // 
            this.cBoxKont.FormattingEnabled = true;
            this.cBoxKont.Location = new System.Drawing.Point(133, 55);
            this.cBoxKont.Name = "cBoxKont";
            this.cBoxKont.Size = new System.Drawing.Size(123, 21);
            this.cBoxKont.TabIndex = 47;
            this.cBoxKont.SelectedIndexChanged += new System.EventHandler(this.cBoxKont_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(133, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ansprechpartner";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxProd
            // 
            this.cBoxProd.FormattingEnabled = true;
            this.cBoxProd.Location = new System.Drawing.Point(88, 151);
            this.cBoxProd.Name = "cBoxProd";
            this.cBoxProd.Size = new System.Drawing.Size(79, 21);
            this.cBoxProd.TabIndex = 49;
            // 
            // AuftragsVerwalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 359);
            this.Controls.Add(this.cBoxProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxKont);
            this.Controls.Add(this.lBoxCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuftr);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAuftrNeu);
            this.Controls.Add(this.btnAuftrBuchen);
            this.Controls.Add(this.btnProdVerw);
            this.Controls.Add(this.nUDMenge);
            this.Controls.Add(this.btnRohVerw);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.lblMenge);
            this.Controls.Add(this.cBoxAutrag);
            this.Controls.Add(this.groupInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AuftragsVerwalt";
            this.Load += new System.EventHandler(this.AuftragsVerwalt_Load);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.ComboBox cBoxProd;

        public System.Windows.Forms.ComboBox cBoxKont;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ListBox lBoxCompany;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblAuftr;

        public System.Windows.Forms.ComboBox cBoxSchritt;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnAuftrNeu;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnAuftrBuchen;

        private System.Windows.Forms.TextBox txtVerbGes;

        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label lblMenge;
        public System.Windows.Forms.ComboBox cBoxAutrag;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.NumericUpDown nUDMenge;

        private System.Windows.Forms.Button btnProdVerw;
        private System.Windows.Forms.Button btnRohVerw;

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerb;
        private System.Windows.Forms.ListBox lBoxRoh;

        #endregion
    }
}