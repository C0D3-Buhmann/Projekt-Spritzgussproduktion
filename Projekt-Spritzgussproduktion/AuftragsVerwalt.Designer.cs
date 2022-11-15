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
            this.cBSchritt = new System.Windows.Forms.ComboBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lBRoh = new System.Windows.Forms.ListBox();
            this.btnProdVerw = new System.Windows.Forms.Button();
            this.btnRohVerw = new System.Windows.Forms.Button();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblMenge = new System.Windows.Forms.Label();
            this.cBAutrag = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.nUDMenge = new System.Windows.Forms.NumericUpDown();
            this.btnAuftrBuchen = new System.Windows.Forms.Button();
            this.btnAuftrNeu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupAuftrVerwalt = new System.Windows.Forms.GroupBox();
            this.lblNewPreisXMenge = new System.Windows.Forms.Label();
            this.lblPpStk = new System.Windows.Forms.Label();
            this.nUDPreisN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDMengeN = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cBoxMitarb = new System.Windows.Forms.ComboBox();
            this.dTPCreated = new System.Windows.Forms.DateTimePicker();
            this.cBoxProd = new System.Windows.Forms.ComboBox();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.cBoxKontakt = new System.Windows.Forms.ComboBox();
            this.lblAuftr = new System.Windows.Forms.Label();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).BeginInit();
            this.groupAuftrVerwalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreisN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMengeN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.cBSchritt);
            this.groupInfo.Controls.Add(this.txtProID);
            this.groupInfo.Controls.Add(this.textBox1);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.textBox3);
            this.groupInfo.Controls.Add(this.lBRoh);
            this.groupInfo.Location = new System.Drawing.Point(249, 64);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(425, 339);
            this.groupInfo.TabIndex = 17;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Info";
            // 
            // cBSchritt
            // 
            this.cBSchritt.FormattingEnabled = true;
            this.cBSchritt.Location = new System.Drawing.Point(6, 65);
            this.cBSchritt.Name = "cBSchritt";
            this.cBSchritt.Size = new System.Drawing.Size(59, 21);
            this.cBSchritt.TabIndex = 32;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(6, 39);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(59, 20);
            this.txtProID.TabIndex = 12;
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(295, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 10;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBRoh
            // 
            this.lBRoh.FormattingEnabled = true;
            this.lBRoh.Location = new System.Drawing.Point(71, 19);
            this.lBRoh.Name = "lBRoh";
            this.lBRoh.Size = new System.Drawing.Size(218, 303);
            this.lBRoh.TabIndex = 3;
            // 
            // btnProdVerw
            // 
            this.btnProdVerw.Location = new System.Drawing.Point(693, 261);
            this.btnProdVerw.Name = "btnProdVerw";
            this.btnProdVerw.Size = new System.Drawing.Size(110, 28);
            this.btnProdVerw.TabIndex = 15;
            this.btnProdVerw.Text = "Produktverwaltung";
            this.btnProdVerw.UseVisualStyleBackColor = true;
            // 
            // btnRohVerw
            // 
            this.btnRohVerw.Location = new System.Drawing.Point(693, 295);
            this.btnRohVerw.Name = "btnRohVerw";
            this.btnRohVerw.Size = new System.Drawing.Size(110, 28);
            this.btnRohVerw.TabIndex = 11;
            this.btnRohVerw.Text = "Rohstoffverwaltung";
            this.btnRohVerw.UseVisualStyleBackColor = true;
            // 
            // lblPreis
            // 
            this.lblPreis.Location = new System.Drawing.Point(173, 12);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(70, 20);
            this.lblPreis.TabIndex = 25;
            this.lblPreis.Text = "Preis";
            this.lblPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenge
            // 
            this.lblMenge.Location = new System.Drawing.Point(12, 38);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(70, 20);
            this.lblMenge.TabIndex = 22;
            this.lblMenge.Text = "Menge";
            this.lblMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBAutrag
            // 
            this.cBAutrag.FormattingEnabled = true;
            this.cBAutrag.Location = new System.Drawing.Point(88, 11);
            this.cBAutrag.Name = "cBAutrag";
            this.cBAutrag.Size = new System.Drawing.Size(79, 21);
            this.cBAutrag.TabIndex = 20;
            this.cBAutrag.TextChanged += new System.EventHandler(this.cBAutrag_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 64);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 28);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Ändern";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // nUDMenge
            // 
            this.nUDMenge.Location = new System.Drawing.Point(88, 38);
            this.nUDMenge.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMenge.Name = "nUDMenge";
            this.nUDMenge.Size = new System.Drawing.Size(155, 20);
            this.nUDMenge.TabIndex = 27;
            this.nUDMenge.ValueChanged += new System.EventHandler(this.nUDMenge_ValueChanged);
            // 
            // btnAuftrBuchen
            // 
            this.btnAuftrBuchen.Enabled = false;
            this.btnAuftrBuchen.Location = new System.Drawing.Point(693, 377);
            this.btnAuftrBuchen.Name = "btnAuftrBuchen";
            this.btnAuftrBuchen.Size = new System.Drawing.Size(110, 28);
            this.btnAuftrBuchen.TabIndex = 28;
            this.btnAuftrBuchen.Text = "Auftrag Buchen";
            this.btnAuftrBuchen.UseVisualStyleBackColor = true;
            this.btnAuftrBuchen.Click += new System.EventHandler(this.btnAuftrBuchen_Click);
            // 
            // btnAuftrNeu
            // 
            this.btnAuftrNeu.Location = new System.Drawing.Point(12, 98);
            this.btnAuftrNeu.Name = "btnAuftrNeu";
            this.btnAuftrNeu.Size = new System.Drawing.Size(231, 28);
            this.btnAuftrNeu.TabIndex = 29;
            this.btnAuftrNeu.Text = "Neu Anlegen";
            this.btnAuftrNeu.UseVisualStyleBackColor = true;
            this.btnAuftrNeu.Click += new System.EventHandler(this.btnAuftrNeu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 28);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(693, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 27);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupAuftrVerwalt
            // 
            this.groupAuftrVerwalt.Controls.Add(this.lblNewPreisXMenge);
            this.groupAuftrVerwalt.Controls.Add(this.lblPpStk);
            this.groupAuftrVerwalt.Controls.Add(this.nUDPreisN);
            this.groupAuftrVerwalt.Controls.Add(this.label2);
            this.groupAuftrVerwalt.Controls.Add(this.nUDMengeN);
            this.groupAuftrVerwalt.Controls.Add(this.btnAccept);
            this.groupAuftrVerwalt.Controls.Add(this.cBoxMitarb);
            this.groupAuftrVerwalt.Controls.Add(this.dTPCreated);
            this.groupAuftrVerwalt.Controls.Add(this.cBoxProd);
            this.groupAuftrVerwalt.Controls.Add(this.cBoxStatus);
            this.groupAuftrVerwalt.Controls.Add(this.cBoxKontakt);
            this.groupAuftrVerwalt.Location = new System.Drawing.Point(12, 134);
            this.groupAuftrVerwalt.Name = "groupAuftrVerwalt";
            this.groupAuftrVerwalt.Size = new System.Drawing.Size(228, 271);
            this.groupAuftrVerwalt.TabIndex = 32;
            this.groupAuftrVerwalt.TabStop = false;
            this.groupAuftrVerwalt.Visible = false;
            // 
            // lblNewPreisXMenge
            // 
            this.lblNewPreisXMenge.Location = new System.Drawing.Point(10, 179);
            this.lblNewPreisXMenge.Name = "lblNewPreisXMenge";
            this.lblNewPreisXMenge.Size = new System.Drawing.Size(143, 20);
            this.lblNewPreisXMenge.TabIndex = 34;
            this.lblNewPreisXMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPpStk
            // 
            this.lblPpStk.Location = new System.Drawing.Point(10, 154);
            this.lblPpStk.Name = "lblPpStk";
            this.lblPpStk.Size = new System.Drawing.Size(58, 20);
            this.lblPpStk.TabIndex = 36;
            this.lblPpStk.Text = "Preis / Stk";
            this.lblPpStk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDPreisN
            // 
            this.nUDPreisN.DecimalPlaces = 2;
            this.nUDPreisN.Location = new System.Drawing.Point(74, 154);
            this.nUDPreisN.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDPreisN.Name = "nUDPreisN";
            this.nUDPreisN.Size = new System.Drawing.Size(80, 20);
            this.nUDPreisN.TabIndex = 35;
            this.nUDPreisN.ValueChanged += new System.EventHandler(this.nUDPreisN_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Menge";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDMengeN
            // 
            this.nUDMengeN.Location = new System.Drawing.Point(74, 125);
            this.nUDMengeN.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMengeN.Name = "nUDMengeN";
            this.nUDMengeN.Size = new System.Drawing.Size(80, 20);
            this.nUDMengeN.TabIndex = 34;
            this.nUDMengeN.ValueChanged += new System.EventHandler(this.nUDMengeN_ValueChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(160, 125);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(62, 129);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "button1";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cBoxMitarb
            // 
            this.cBoxMitarb.FormattingEnabled = true;
            this.cBoxMitarb.Location = new System.Drawing.Point(118, 18);
            this.cBoxMitarb.Name = "cBoxMitarb";
            this.cBoxMitarb.Size = new System.Drawing.Size(104, 21);
            this.cBoxMitarb.TabIndex = 5;
            // 
            // dTPCreated
            // 
            this.dTPCreated.Location = new System.Drawing.Point(10, 72);
            this.dTPCreated.Name = "dTPCreated";
            this.dTPCreated.Size = new System.Drawing.Size(212, 20);
            this.dTPCreated.TabIndex = 4;
            // 
            // cBoxProd
            // 
            this.cBoxProd.FormattingEnabled = true;
            this.cBoxProd.Location = new System.Drawing.Point(10, 45);
            this.cBoxProd.Name = "cBoxProd";
            this.cBoxProd.Size = new System.Drawing.Size(212, 21);
            this.cBoxProd.TabIndex = 2;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(10, 98);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(212, 21);
            this.cBoxStatus.TabIndex = 1;
            // 
            // cBoxKontakt
            // 
            this.cBoxKontakt.FormattingEnabled = true;
            this.cBoxKontakt.Location = new System.Drawing.Point(9, 18);
            this.cBoxKontakt.Name = "cBoxKontakt";
            this.cBoxKontakt.Size = new System.Drawing.Size(104, 21);
            this.cBoxKontakt.TabIndex = 0;
            // 
            // lblAuftr
            // 
            this.lblAuftr.Location = new System.Drawing.Point(12, 11);
            this.lblAuftr.Name = "lblAuftr";
            this.lblAuftr.Size = new System.Drawing.Size(70, 20);
            this.lblAuftr.TabIndex = 33;
            this.lblAuftr.Text = "Auftrag";
            this.lblAuftr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuftragsVerwalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.lblAuftr);
            this.Controls.Add(this.groupAuftrVerwalt);
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
            this.Controls.Add(this.cBAutrag);
            this.Controls.Add(this.groupInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AuftragsVerwalt";
            this.Load += new System.EventHandler(this.AuftragsVerwalt_Load);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).EndInit();
            this.groupAuftrVerwalt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreisN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMengeN)).EndInit();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.NumericUpDown nUDMengeN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPpStk;
        public System.Windows.Forms.NumericUpDown nUDPreisN;
        private System.Windows.Forms.Label lblNewPreisXMenge;

        private System.Windows.Forms.Label lblAuftr;

        private System.Windows.Forms.Button btnAccept;

        private System.Windows.Forms.DateTimePicker dTPCreated;
        private System.Windows.Forms.ComboBox cBoxMitarb;

        private System.Windows.Forms.ComboBox cBoxKontakt;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.ComboBox cBoxProd;

        private System.Windows.Forms.GroupBox groupAuftrVerwalt;

        public System.Windows.Forms.ComboBox cBSchritt;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox txtProID;

        private System.Windows.Forms.Button btnAuftrNeu;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnAuftrBuchen;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label lblMenge;
        public System.Windows.Forms.ComboBox cBAutrag;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.NumericUpDown nUDMenge;

        private System.Windows.Forms.Button btnProdVerw;
        private System.Windows.Forms.Button btnRohVerw;

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lBRoh;

        #endregion
    }
}