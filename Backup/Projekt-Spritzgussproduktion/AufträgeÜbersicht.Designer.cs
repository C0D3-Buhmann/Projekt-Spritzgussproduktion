using System.ComponentModel;

namespace Projekt_Spritzgussproduktion
{
    partial class AufträgeÜbersicht
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
            this.txtReload = new System.Windows.Forms.Button();
            this.lblAuftr = new System.Windows.Forms.Label();
            this.groupAuftrVerwalt = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSavePM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxCompany = new System.Windows.Forms.ComboBox();
            this.lblKund = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clBProd = new System.Windows.Forms.CheckedListBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAuftrNeu = new System.Windows.Forms.Button();
            this.btnAuftrBuchen = new System.Windows.Forms.Button();
            this.btnProdVerw = new System.Windows.Forms.Button();
            this.nUDMenge = new System.Windows.Forms.NumericUpDown();
            this.btnRohVerw = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblMenge = new System.Windows.Forms.Label();
            this.cBAutrag = new System.Windows.Forms.ComboBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.cBSchritt = new System.Windows.Forms.ComboBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lBRoh = new System.Windows.Forms.ListBox();
            this.groupAuftrVerwalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreisN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMengeN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReload
            // 
            this.txtReload.Location = new System.Drawing.Point(832, 510);
            this.txtReload.Name = "txtReload";
            this.txtReload.Size = new System.Drawing.Size(52, 61);
            this.txtReload.TabIndex = 49;
            this.txtReload.Text = "R";
            this.txtReload.UseVisualStyleBackColor = true;
            // 
            // lblAuftr
            // 
            this.lblAuftr.Location = new System.Drawing.Point(12, 9);
            this.lblAuftr.Name = "lblAuftr";
            this.lblAuftr.Size = new System.Drawing.Size(70, 20);
            this.lblAuftr.TabIndex = 48;
            this.lblAuftr.Text = "Auftrag";
            this.lblAuftr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupAuftrVerwalt
            // 
            this.groupAuftrVerwalt.Controls.Add(this.panel4);
            this.groupAuftrVerwalt.Controls.Add(this.btnSavePM);
            this.groupAuftrVerwalt.Controls.Add(this.panel3);
            this.groupAuftrVerwalt.Controls.Add(this.panel2);
            this.groupAuftrVerwalt.Controls.Add(this.panel1);
            this.groupAuftrVerwalt.Controls.Add(this.label9);
            this.groupAuftrVerwalt.Controls.Add(this.label10);
            this.groupAuftrVerwalt.Controls.Add(this.label7);
            this.groupAuftrVerwalt.Controls.Add(this.label8);
            this.groupAuftrVerwalt.Controls.Add(this.label6);
            this.groupAuftrVerwalt.Controls.Add(this.label4);
            this.groupAuftrVerwalt.Controls.Add(this.txtLocation);
            this.groupAuftrVerwalt.Controls.Add(this.txtTel);
            this.groupAuftrVerwalt.Controls.Add(this.txtEmail);
            this.groupAuftrVerwalt.Controls.Add(this.btnConfirm);
            this.groupAuftrVerwalt.Controls.Add(this.btnEdit);
            this.groupAuftrVerwalt.Controls.Add(this.txtFax);
            this.groupAuftrVerwalt.Controls.Add(this.txtInfo);
            this.groupAuftrVerwalt.Controls.Add(this.label5);
            this.groupAuftrVerwalt.Controls.Add(this.cBoxCompany);
            this.groupAuftrVerwalt.Controls.Add(this.lblKund);
            this.groupAuftrVerwalt.Controls.Add(this.label1);
            this.groupAuftrVerwalt.Controls.Add(this.clBProd);
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
            this.groupAuftrVerwalt.Location = new System.Drawing.Point(12, 130);
            this.groupAuftrVerwalt.Name = "groupAuftrVerwalt";
            this.groupAuftrVerwalt.Size = new System.Drawing.Size(551, 484);
            this.groupAuftrVerwalt.TabIndex = 47;
            this.groupAuftrVerwalt.TabStop = false;
            this.groupAuftrVerwalt.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(14, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 3);
            this.panel4.TabIndex = 55;
            // 
            // btnSavePM
            // 
            this.btnSavePM.Enabled = false;
            this.btnSavePM.Location = new System.Drawing.Point(460, 93);
            this.btnSavePM.Name = "btnSavePM";
            this.btnSavePM.Size = new System.Drawing.Size(80, 20);
            this.btnSavePM.TabIndex = 55;
            this.btnSavePM.Text = "Save";
            this.btnSavePM.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(6, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 3);
            this.panel3.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(239, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 182);
            this.panel2.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(239, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 260);
            this.panel1.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(388, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Fax";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(255, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Tel";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(388, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(255, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Info";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(122, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Kunde";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Kunden Kontakt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(255, 349);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(167, 129);
            this.txtLocation.TabIndex = 46;
            this.txtLocation.Text = "Standort";
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(255, 286);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(124, 20);
            this.txtTel.TabIndex = 45;
            this.txtTel.Text = "Tel";
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(388, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 44;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(255, 128);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 46);
            this.btnConfirm.TabIndex = 43;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(388, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 46);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(388, 286);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(157, 20);
            this.txtFax.TabIndex = 33;
            this.txtFax.Text = "Fax";
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(255, 239);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(124, 20);
            this.txtInfo.TabIndex = 33;
            this.txtInfo.Text = "Info";
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mitarbeiter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxCompany
            // 
            this.cBoxCompany.FormattingEnabled = true;
            this.cBoxCompany.Location = new System.Drawing.Point(122, 239);
            this.cBoxCompany.Name = "cBoxCompany";
            this.cBoxCompany.Size = new System.Drawing.Size(104, 21);
            this.cBoxCompany.TabIndex = 40;
            // 
            // lblKund
            // 
            this.lblKund.Location = new System.Drawing.Point(12, 194);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(478, 20);
            this.lblKund.TabIndex = 39;
            this.lblKund.Text = "Kunden Informationen";
            this.lblKund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(278, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Menge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clBProd
            // 
            this.clBProd.FormattingEnabled = true;
            this.clBProd.Location = new System.Drawing.Point(14, 20);
            this.clBProd.Name = "clBProd";
            this.clBProd.Size = new System.Drawing.Size(212, 154);
            this.clBProd.TabIndex = 37;
            // 
            // lblNewPreisXMenge
            // 
            this.lblNewPreisXMenge.Location = new System.Drawing.Point(460, 69);
            this.lblNewPreisXMenge.Name = "lblNewPreisXMenge";
            this.lblNewPreisXMenge.Size = new System.Drawing.Size(80, 20);
            this.lblNewPreisXMenge.TabIndex = 34;
            this.lblNewPreisXMenge.Text = "EndPreis";
            this.lblNewPreisXMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPpStk
            // 
            this.lblPpStk.Location = new System.Drawing.Point(310, 100);
            this.lblPpStk.Name = "lblPpStk";
            this.lblPpStk.Size = new System.Drawing.Size(58, 20);
            this.lblPpStk.TabIndex = 36;
            this.lblPpStk.Text = "Preis / Stk";
            this.lblPpStk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDPreisN
            // 
            this.nUDPreisN.DecimalPlaces = 2;
            this.nUDPreisN.Enabled = false;
            this.nUDPreisN.Location = new System.Drawing.Point(374, 100);
            this.nUDPreisN.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDPreisN.Name = "nUDPreisN";
            this.nUDPreisN.Size = new System.Drawing.Size(80, 20);
            this.nUDPreisN.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(310, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Menge";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDMengeN
            // 
            this.nUDMengeN.Enabled = false;
            this.nUDMengeN.Location = new System.Drawing.Point(374, 71);
            this.nUDMengeN.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMengeN.Name = "nUDMengeN";
            this.nUDMengeN.Size = new System.Drawing.Size(80, 20);
            this.nUDMengeN.TabIndex = 34;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(428, 349);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 129);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "button1";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // cBoxMitarb
            // 
            this.cBoxMitarb.FormattingEnabled = true;
            this.cBoxMitarb.Location = new System.Drawing.Point(12, 371);
            this.cBoxMitarb.Name = "cBoxMitarb";
            this.cBoxMitarb.Size = new System.Drawing.Size(212, 21);
            this.cBoxMitarb.TabIndex = 5;
            // 
            // dTPCreated
            // 
            this.dTPCreated.Enabled = false;
            this.dTPCreated.Location = new System.Drawing.Point(12, 401);
            this.dTPCreated.Name = "dTPCreated";
            this.dTPCreated.Size = new System.Drawing.Size(212, 20);
            this.dTPCreated.TabIndex = 4;
            this.dTPCreated.Visible = false;
            // 
            // cBoxProd
            // 
            this.cBoxProd.Enabled = false;
            this.cBoxProd.FormattingEnabled = true;
            this.cBoxProd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cBoxProd.Location = new System.Drawing.Point(255, 38);
            this.cBoxProd.Name = "cBoxProd";
            this.cBoxProd.Size = new System.Drawing.Size(290, 21);
            this.cBoxProd.TabIndex = 2;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(12, 427);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(212, 21);
            this.cBoxStatus.TabIndex = 1;
            // 
            // cBoxKontakt
            // 
            this.cBoxKontakt.FormattingEnabled = true;
            this.cBoxKontakt.Location = new System.Drawing.Point(13, 239);
            this.cBoxKontakt.Name = "cBoxKontakt";
            this.cBoxKontakt.Size = new System.Drawing.Size(104, 21);
            this.cBoxKontakt.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(890, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 27);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 28);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAuftrNeu
            // 
            this.btnAuftrNeu.Location = new System.Drawing.Point(12, 96);
            this.btnAuftrNeu.Name = "btnAuftrNeu";
            this.btnAuftrNeu.Size = new System.Drawing.Size(231, 28);
            this.btnAuftrNeu.TabIndex = 44;
            this.btnAuftrNeu.Text = "Neu Anlegen";
            this.btnAuftrNeu.UseVisualStyleBackColor = true;
            // 
            // btnAuftrBuchen
            // 
            this.btnAuftrBuchen.Enabled = false;
            this.btnAuftrBuchen.Location = new System.Drawing.Point(890, 510);
            this.btnAuftrBuchen.Name = "btnAuftrBuchen";
            this.btnAuftrBuchen.Size = new System.Drawing.Size(110, 28);
            this.btnAuftrBuchen.TabIndex = 43;
            this.btnAuftrBuchen.Text = "Auftrag Buchen";
            this.btnAuftrBuchen.UseVisualStyleBackColor = true;
            // 
            // btnProdVerw
            // 
            this.btnProdVerw.Location = new System.Drawing.Point(890, 10);
            this.btnProdVerw.Name = "btnProdVerw";
            this.btnProdVerw.Size = new System.Drawing.Size(110, 28);
            this.btnProdVerw.TabIndex = 36;
            this.btnProdVerw.Text = "Produktverwaltung";
            this.btnProdVerw.UseVisualStyleBackColor = true;
            // 
            // nUDMenge
            // 
            this.nUDMenge.Location = new System.Drawing.Point(88, 36);
            this.nUDMenge.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMenge.Name = "nUDMenge";
            this.nUDMenge.Size = new System.Drawing.Size(155, 20);
            this.nUDMenge.TabIndex = 42;
            // 
            // btnRohVerw
            // 
            this.btnRohVerw.Location = new System.Drawing.Point(890, 44);
            this.btnRohVerw.Name = "btnRohVerw";
            this.btnRohVerw.Size = new System.Drawing.Size(110, 28);
            this.btnRohVerw.TabIndex = 35;
            this.btnRohVerw.Text = "Rohstoffverwaltung";
            this.btnRohVerw.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 62);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 28);
            this.btnChange.TabIndex = 41;
            this.btnChange.Text = "Ändern";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // lblPreis
            // 
            this.lblPreis.Location = new System.Drawing.Point(173, 10);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(70, 20);
            this.lblPreis.TabIndex = 40;
            this.lblPreis.Text = "Preis";
            this.lblPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenge
            // 
            this.lblMenge.Location = new System.Drawing.Point(12, 36);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(70, 20);
            this.lblMenge.TabIndex = 39;
            this.lblMenge.Text = "Menge";
            this.lblMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBAutrag
            // 
            this.cBAutrag.FormattingEnabled = true;
            this.cBAutrag.Location = new System.Drawing.Point(88, 9);
            this.cBAutrag.Name = "cBAutrag";
            this.cBAutrag.Size = new System.Drawing.Size(79, 21);
            this.cBAutrag.TabIndex = 38;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.cBSchritt);
            this.groupInfo.Controls.Add(this.txtProID);
            this.groupInfo.Controls.Add(this.textBox1);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.textBox3);
            this.groupInfo.Controls.Add(this.lBRoh);
            this.groupInfo.Location = new System.Drawing.Point(563, 130);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(442, 335);
            this.groupInfo.TabIndex = 37;
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
            this.lBRoh.Size = new System.Drawing.Size(202, 303);
            this.lBRoh.TabIndex = 3;
            // 
            // AufträgeÜbersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 619);
            this.Controls.Add(this.txtReload);
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
            this.Name = "AufträgeÜbersicht";
            this.Text = "AufträgeÜbersicht";
            this.groupAuftrVerwalt.ResumeLayout(false);
            this.groupAuftrVerwalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreisN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMengeN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button txtReload;
        private System.Windows.Forms.Label lblAuftr;
        private System.Windows.Forms.GroupBox groupAuftrVerwalt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSavePM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxCompany;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clBProd;
        private System.Windows.Forms.Label lblNewPreisXMenge;
        private System.Windows.Forms.Label lblPpStk;
        public System.Windows.Forms.NumericUpDown nUDPreisN;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nUDMengeN;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cBoxMitarb;
        private System.Windows.Forms.DateTimePicker dTPCreated;
        private System.Windows.Forms.ComboBox cBoxProd;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.ComboBox cBoxKontakt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAuftrNeu;
        private System.Windows.Forms.Button btnAuftrBuchen;
        private System.Windows.Forms.Button btnProdVerw;
        public System.Windows.Forms.NumericUpDown nUDMenge;
        private System.Windows.Forms.Button btnRohVerw;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label lblMenge;
        public System.Windows.Forms.ComboBox cBAutrag;
        private System.Windows.Forms.GroupBox groupInfo;
        public System.Windows.Forms.ComboBox cBSchritt;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lBRoh;

        #endregion
    }
}