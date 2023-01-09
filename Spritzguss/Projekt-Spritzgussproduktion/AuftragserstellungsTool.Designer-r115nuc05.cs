using System.ComponentModel;

namespace Projekt_Spritzgussproduktion
{
    partial class AuftragserstellungsTool
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
            this.cLBoxProd = new System.Windows.Forms.CheckedListBox();
            this.cBoxProd = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblMenge = new System.Windows.Forms.Label();
            this.nUDMenge = new System.Windows.Forms.NumericUpDown();
            this.nUDPreis = new System.Windows.Forms.NumericUpDown();
            this.lblPreis = new System.Windows.Forms.Label();
            this.btnSafe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxMitarb = new System.Windows.Forms.ComboBox();
            this.lblMitarb = new System.Windows.Forms.Label();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtGesammt = new System.Windows.Forms.TextBox();
            this.lblGPreis = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuchen = new System.Windows.Forms.Button();
            this.btnLieferS = new System.Windows.Forms.Button();
            this.btnProdukte = new System.Windows.Forms.Button();
            this.btnRechnung = new System.Windows.Forms.Button();
            this.btnWinCount = new System.Windows.Forms.TextBox();
            this.checcheckBSaved = new System.Windows.Forms.CheckBox();
            this.txtLIDX = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtLMenge = new System.Windows.Forms.TextBox();
            this.txtLPreis = new System.Windows.Forms.TextBox();
            this.txtLGesammtPreis = new System.Windows.Forms.TextBox();
            this.txtLChecked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnBackward2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMitEmail = new System.Windows.Forms.TextBox();
            this.txtKundAbteilung = new System.Windows.Forms.TextBox();
            this.txtMitUserName = new System.Windows.Forms.TextBox();
            this.txtMitUUID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnLastBack = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnConfirmMitarb = new System.Windows.Forms.Button();
            this.btnMitBack = new System.Windows.Forms.Button();
            this.txtKundPosition = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtKundID = new System.Windows.Forms.TextBox();
            this.cBoxKontakt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lBoxCompany = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtKundFax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKundTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKontaktID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtKundLocation = new System.Windows.Forms.TextBox();
            this.txtKundEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStandort = new System.Windows.Forms.Label();
            this.btnKundBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gBoxCon = new System.Windows.Forms.GroupBox();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.dTPCreated = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreis)).BeginInit();
            this.panel3.SuspendLayout();
            this.gBoxCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLBoxProd
            // 
            this.cLBoxProd.FormattingEnabled = true;
            this.cLBoxProd.Location = new System.Drawing.Point(12, 32);
            this.cLBoxProd.Name = "cLBoxProd";
            this.cLBoxProd.Size = new System.Drawing.Size(154, 199);
            this.cLBoxProd.TabIndex = 0;
            // 
            // cBoxProd
            // 
            this.cBoxProd.Enabled = false;
            this.cBoxProd.FormattingEnabled = true;
            this.cBoxProd.Location = new System.Drawing.Point(172, 32);
            this.cBoxProd.Name = "cBoxProd";
            this.cBoxProd.Size = new System.Drawing.Size(212, 21);
            this.cBoxProd.TabIndex = 1;
            this.cBoxProd.SelectedIndexChanged += new System.EventHandler(this.cBoxProd_SelectedIndexChanged);
            this.cBoxProd.TextChanged += new System.EventHandler(this.cBoxProd_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(172, 202);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(103, 29);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Bestätigen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblMenge
            // 
            this.lblMenge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMenge.Location = new System.Drawing.Point(172, 56);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(103, 20);
            this.lblMenge.TabIndex = 4;
            this.lblMenge.Text = "Menge";
            this.lblMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDMenge
            // 
            this.nUDMenge.Enabled = false;
            this.nUDMenge.Location = new System.Drawing.Point(281, 56);
            this.nUDMenge.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMenge.Name = "nUDMenge";
            this.nUDMenge.Size = new System.Drawing.Size(103, 20);
            this.nUDMenge.TabIndex = 5;
            this.nUDMenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDMenge.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDMenge.ValueChanged += new System.EventHandler(this.nUDMenge_ValueChanged);
            // 
            // nUDPreis
            // 
            this.nUDPreis.DecimalPlaces = 2;
            this.nUDPreis.Enabled = false;
            this.nUDPreis.Location = new System.Drawing.Point(281, 82);
            this.nUDPreis.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nUDPreis.Name = "nUDPreis";
            this.nUDPreis.Size = new System.Drawing.Size(103, 20);
            this.nUDPreis.TabIndex = 6;
            this.nUDPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDPreis.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDPreis.ValueChanged += new System.EventHandler(this.nUDPreis_ValueChanged);
            // 
            // lblPreis
            // 
            this.lblPreis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPreis.Location = new System.Drawing.Point(172, 82);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(103, 20);
            this.lblPreis.TabIndex = 7;
            this.lblPreis.Text = "Preis";
            this.lblPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSafe
            // 
            this.btnSafe.Enabled = false;
            this.btnSafe.Location = new System.Drawing.Point(281, 202);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(103, 29);
            this.btnSafe.TabIndex = 9;
            this.btnSafe.Text = "Sichern";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Produkt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(390, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 228);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(582, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 182);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 3);
            this.panel3.TabIndex = 17;
            // 
            // cBoxMitarb
            // 
            this.cBoxMitarb.Enabled = false;
            this.cBoxMitarb.FormattingEnabled = true;
            this.cBoxMitarb.Location = new System.Drawing.Point(399, 32);
            this.cBoxMitarb.Name = "cBoxMitarb";
            this.cBoxMitarb.Size = new System.Drawing.Size(239, 21);
            this.cBoxMitarb.TabIndex = 35;
            this.cBoxMitarb.SelectedIndexChanged += new System.EventHandler(this.cBoxMitarb_SelectedIndexChanged);
            this.cBoxMitarb.TextChanged += new System.EventHandler(this.cBoxMitarb_TextChanged);
            // 
            // lblMitarb
            // 
            this.lblMitarb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMitarb.Location = new System.Drawing.Point(399, 10);
            this.lblMitarb.Name = "lblMitarb";
            this.lblMitarb.Size = new System.Drawing.Size(239, 20);
            this.lblMitarb.TabIndex = 36;
            this.lblMitarb.Text = "Mitarbeiter";
            this.lblMitarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackward
            // 
            this.btnBackward.Enabled = false;
            this.btnBackward.Location = new System.Drawing.Point(281, 167);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(49, 29);
            this.btnBackward.TabIndex = 37;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(335, 167);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(49, 29);
            this.btnForward.TabIndex = 38;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtGesammt
            // 
            this.txtGesammt.Enabled = false;
            this.txtGesammt.Location = new System.Drawing.Point(281, 108);
            this.txtGesammt.Name = "txtGesammt";
            this.txtGesammt.ReadOnly = true;
            this.txtGesammt.Size = new System.Drawing.Size(103, 20);
            this.txtGesammt.TabIndex = 40;
            // 
            // lblGPreis
            // 
            this.lblGPreis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGPreis.Location = new System.Drawing.Point(172, 108);
            this.lblGPreis.Name = "lblGPreis";
            this.lblGPreis.Size = new System.Drawing.Size(103, 20);
            this.lblGPreis.TabIndex = 41;
            this.lblGPreis.Text = "Gesammt";
            this.lblGPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(653, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 29);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(644, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 437);
            this.panel4.TabIndex = 16;
            // 
            // btnBuchen
            // 
            this.btnBuchen.Enabled = false;
            this.btnBuchen.Location = new System.Drawing.Point(713, 421);
            this.btnBuchen.Name = "btnBuchen";
            this.btnBuchen.Size = new System.Drawing.Size(144, 28);
            this.btnBuchen.TabIndex = 57;
            this.btnBuchen.Text = "Buchen";
            this.btnBuchen.UseVisualStyleBackColor = true;
            this.btnBuchen.Click += new System.EventHandler(this.btnBuchen_Click);
            // 
            // btnLieferS
            // 
            this.btnLieferS.Location = new System.Drawing.Point(653, 82);
            this.btnLieferS.Name = "btnLieferS";
            this.btnLieferS.Size = new System.Drawing.Size(204, 28);
            this.btnLieferS.TabIndex = 59;
            this.btnLieferS.Text = "Lieferscheine";
            this.btnLieferS.UseVisualStyleBackColor = true;
            // 
            // btnProdukte
            // 
            this.btnProdukte.Location = new System.Drawing.Point(653, 12);
            this.btnProdukte.Name = "btnProdukte";
            this.btnProdukte.Size = new System.Drawing.Size(204, 28);
            this.btnProdukte.TabIndex = 60;
            this.btnProdukte.Text = "Produkte";
            this.btnProdukte.UseVisualStyleBackColor = true;
            // 
            // btnRechnung
            // 
            this.btnRechnung.Location = new System.Drawing.Point(653, 116);
            this.btnRechnung.Name = "btnRechnung";
            this.btnRechnung.Size = new System.Drawing.Size(204, 28);
            this.btnRechnung.TabIndex = 61;
            this.btnRechnung.Text = "Rechnungen\r\n";
            this.btnRechnung.UseVisualStyleBackColor = true;
            // 
            // btnWinCount
            // 
            this.btnWinCount.Enabled = false;
            this.btnWinCount.Location = new System.Drawing.Point(253, 176);
            this.btnWinCount.Name = "btnWinCount";
            this.btnWinCount.ReadOnly = true;
            this.btnWinCount.Size = new System.Drawing.Size(22, 20);
            this.btnWinCount.TabIndex = 62;
            // 
            // checcheckBSaved
            // 
            this.checcheckBSaved.Enabled = false;
            this.checcheckBSaved.Location = new System.Drawing.Point(172, 176);
            this.checcheckBSaved.Name = "checcheckBSaved";
            this.checcheckBSaved.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checcheckBSaved.Size = new System.Drawing.Size(75, 20);
            this.checcheckBSaved.TabIndex = 63;
            this.checcheckBSaved.Text = "Gesichert";
            this.checcheckBSaved.UseVisualStyleBackColor = true;
            // 
            // txtLIDX
            // 
            this.txtLIDX.Location = new System.Drawing.Point(653, 235);
            this.txtLIDX.Name = "txtLIDX";
            this.txtLIDX.ReadOnly = true;
            this.txtLIDX.Size = new System.Drawing.Size(99, 20);
            this.txtLIDX.TabIndex = 57;
            this.txtLIDX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(758, 235);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(99, 20);
            this.txtLName.TabIndex = 64;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLMenge
            // 
            this.txtLMenge.Location = new System.Drawing.Point(653, 281);
            this.txtLMenge.Name = "txtLMenge";
            this.txtLMenge.ReadOnly = true;
            this.txtLMenge.Size = new System.Drawing.Size(99, 20);
            this.txtLMenge.TabIndex = 65;
            this.txtLMenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLPreis
            // 
            this.txtLPreis.Location = new System.Drawing.Point(758, 281);
            this.txtLPreis.Name = "txtLPreis";
            this.txtLPreis.ReadOnly = true;
            this.txtLPreis.Size = new System.Drawing.Size(99, 20);
            this.txtLPreis.TabIndex = 66;
            this.txtLPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLGesammtPreis
            // 
            this.txtLGesammtPreis.Location = new System.Drawing.Point(653, 328);
            this.txtLGesammtPreis.Name = "txtLGesammtPreis";
            this.txtLGesammtPreis.ReadOnly = true;
            this.txtLGesammtPreis.Size = new System.Drawing.Size(99, 20);
            this.txtLGesammtPreis.TabIndex = 67;
            this.txtLGesammtPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLChecked
            // 
            this.txtLChecked.Location = new System.Drawing.Point(758, 328);
            this.txtLChecked.Name = "txtLChecked";
            this.txtLChecked.ReadOnly = true;
            this.txtLChecked.Size = new System.Drawing.Size(99, 20);
            this.txtLChecked.TabIndex = 68;
            this.txtLChecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(653, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Gesammt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(758, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Saved";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(758, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Preis";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(653, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Menge";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(653, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(758, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForward2
            // 
            this.btnForward2.Enabled = false;
            this.btnForward2.Location = new System.Drawing.Point(758, 352);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(49, 29);
            this.btnForward2.TabIndex = 76;
            this.btnForward2.Text = ">";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward2_Click);
            // 
            // btnBackward2
            // 
            this.btnBackward2.Enabled = false;
            this.btnBackward2.Location = new System.Drawing.Point(703, 352);
            this.btnBackward2.Name = "btnBackward2";
            this.btnBackward2.Size = new System.Drawing.Size(49, 29);
            this.btnBackward2.TabIndex = 75;
            this.btnBackward2.Text = "<";
            this.btnBackward2.UseVisualStyleBackColor = true;
            this.btnBackward2.Click += new System.EventHandler(this.btnBackward2_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(399, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 88;
            this.label13.Text = "ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(528, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Username";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(399, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 86;
            this.label15.Text = "Abteilung";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(528, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 84;
            this.label17.Text = "Position";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMitEmail
            // 
            this.txtMitEmail.Location = new System.Drawing.Point(528, 79);
            this.txtMitEmail.Name = "txtMitEmail";
            this.txtMitEmail.ReadOnly = true;
            this.txtMitEmail.Size = new System.Drawing.Size(110, 20);
            this.txtMitEmail.TabIndex = 82;
            this.txtMitEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKundAbteilung
            // 
            this.txtKundAbteilung.Location = new System.Drawing.Point(399, 171);
            this.txtKundAbteilung.Name = "txtKundAbteilung";
            this.txtKundAbteilung.ReadOnly = true;
            this.txtKundAbteilung.Size = new System.Drawing.Size(110, 20);
            this.txtKundAbteilung.TabIndex = 79;
            this.txtKundAbteilung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMitUserName
            // 
            this.txtMitUserName.Location = new System.Drawing.Point(528, 125);
            this.txtMitUserName.Name = "txtMitUserName";
            this.txtMitUserName.ReadOnly = true;
            this.txtMitUserName.Size = new System.Drawing.Size(110, 20);
            this.txtMitUserName.TabIndex = 78;
            this.txtMitUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMitUUID
            // 
            this.txtMitUUID.Location = new System.Drawing.Point(399, 79);
            this.txtMitUUID.Name = "txtMitUUID";
            this.txtMitUUID.ReadOnly = true;
            this.txtMitUUID.Size = new System.Drawing.Size(110, 20);
            this.txtMitUUID.TabIndex = 77;
            this.txtMitUUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(390, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(221, 20);
            this.label19.TabIndex = 59;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastBack
            // 
            this.btnLastBack.Enabled = false;
            this.btnLastBack.Location = new System.Drawing.Point(653, 421);
            this.btnLastBack.Name = "btnLastBack";
            this.btnLastBack.Size = new System.Drawing.Size(54, 28);
            this.btnLastBack.TabIndex = 89;
            this.btnLastBack.Text = "Zurück";
            this.btnLastBack.UseVisualStyleBackColor = true;
            this.btnLastBack.Click += new System.EventHandler(this.btnLastBack_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(653, 46);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(204, 28);
            this.btnStatus.TabIndex = 90;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnConfirmMitarb
            // 
            this.btnConfirmMitarb.Enabled = false;
            this.btnConfirmMitarb.Location = new System.Drawing.Point(570, 198);
            this.btnConfirmMitarb.Name = "btnConfirmMitarb";
            this.btnConfirmMitarb.Size = new System.Drawing.Size(68, 29);
            this.btnConfirmMitarb.TabIndex = 43;
            this.btnConfirmMitarb.Text = "Bestätigen";
            this.btnConfirmMitarb.UseVisualStyleBackColor = true;
            this.btnConfirmMitarb.Click += new System.EventHandler(this.btnConfirmMitarb_Click);
            // 
            // btnMitBack
            // 
            this.btnMitBack.Enabled = false;
            this.btnMitBack.Location = new System.Drawing.Point(509, 198);
            this.btnMitBack.Name = "btnMitBack";
            this.btnMitBack.Size = new System.Drawing.Size(55, 29);
            this.btnMitBack.TabIndex = 91;
            this.btnMitBack.Text = "Zurück";
            this.btnMitBack.UseVisualStyleBackColor = true;
            this.btnMitBack.Click += new System.EventHandler(this.btnMitBack_Click);
            // 
            // txtKundPosition
            // 
            this.txtKundPosition.Location = new System.Drawing.Point(528, 172);
            this.txtKundPosition.Name = "txtKundPosition";
            this.txtKundPosition.ReadOnly = true;
            this.txtKundPosition.Size = new System.Drawing.Size(110, 20);
            this.txtKundPosition.TabIndex = 80;
            this.txtKundPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTel.Location = new System.Drawing.Point(528, 56);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(110, 20);
            this.lblTel.TabIndex = 85;
            this.lblTel.Text = "Email";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(399, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 20);
            this.label16.TabIndex = 92;
            this.label16.Text = "Password";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(399, 125);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.ReadOnly = true;
            this.txtPasswd.Size = new System.Drawing.Size(110, 20);
            this.txtPasswd.TabIndex = 93;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKundID
            // 
            this.txtKundID.Location = new System.Drawing.Point(393, 38);
            this.txtKundID.Name = "txtKundID";
            this.txtKundID.ReadOnly = true;
            this.txtKundID.Size = new System.Drawing.Size(106, 20);
            this.txtKundID.TabIndex = 40;
            // 
            // cBoxKontakt
            // 
            this.cBoxKontakt.FormattingEnabled = true;
            this.cBoxKontakt.Location = new System.Drawing.Point(166, 38);
            this.cBoxKontakt.Name = "cBoxKontakt";
            this.cBoxKontakt.Size = new System.Drawing.Size(218, 21);
            this.cBoxKontakt.TabIndex = 41;
            this.cBoxKontakt.SelectedIndexChanged += new System.EventHandler(this.cBoxKontakt_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(166, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Kontakt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Unternehmen";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBoxCompany
            // 
            this.lBoxCompany.FormattingEnabled = true;
            this.lBoxCompany.Location = new System.Drawing.Point(5, 38);
            this.lBoxCompany.Name = "lBoxCompany";
            this.lBoxCompany.Size = new System.Drawing.Size(154, 160);
            this.lBoxCompany.TabIndex = 44;
            this.lBoxCompany.SelectedIndexChanged += new System.EventHandler(this.lBoxCompany_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(390, 162);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(156, 36);
            this.btnAccept.TabIndex = 45;
            this.btnAccept.Text = "Bestätigen";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(505, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 20);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "KontaktID";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKundFax
            // 
            this.txtKundFax.Location = new System.Drawing.Point(278, 84);
            this.txtKundFax.Name = "txtKundFax";
            this.txtKundFax.ReadOnly = true;
            this.txtKundFax.Size = new System.Drawing.Size(106, 20);
            this.txtKundFax.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(278, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fax";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKundTel
            // 
            this.txtKundTel.Location = new System.Drawing.Point(166, 85);
            this.txtKundTel.Name = "txtKundTel";
            this.txtKundTel.ReadOnly = true;
            this.txtKundTel.Size = new System.Drawing.Size(106, 20);
            this.txtKundTel.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(166, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Telefon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKontaktID
            // 
            this.txtKontaktID.Location = new System.Drawing.Point(505, 38);
            this.txtKontaktID.Name = "txtKontaktID";
            this.txtKontaktID.ReadOnly = true;
            this.txtKontaktID.Size = new System.Drawing.Size(106, 20);
            this.txtKontaktID.TabIndex = 51;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl.Location = new System.Drawing.Point(393, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 20);
            this.lbl.TabIndex = 52;
            this.lbl.Text = "KundenID";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKundLocation
            // 
            this.txtKundLocation.Location = new System.Drawing.Point(166, 131);
            this.txtKundLocation.Multiline = true;
            this.txtKundLocation.Name = "txtKundLocation";
            this.txtKundLocation.ReadOnly = true;
            this.txtKundLocation.Size = new System.Drawing.Size(218, 67);
            this.txtKundLocation.TabIndex = 53;
            // 
            // txtKundEmail
            // 
            this.txtKundEmail.Location = new System.Drawing.Point(393, 84);
            this.txtKundEmail.Name = "txtKundEmail";
            this.txtKundEmail.ReadOnly = true;
            this.txtKundEmail.Size = new System.Drawing.Size(218, 20);
            this.txtKundEmail.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(393, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStandort
            // 
            this.lblStandort.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStandort.Location = new System.Drawing.Point(166, 108);
            this.lblStandort.Name = "lblStandort";
            this.lblStandort.Size = new System.Drawing.Size(218, 20);
            this.lblStandort.TabIndex = 56;
            this.lblStandort.Text = "Rechnungsadresse";
            this.lblStandort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKundBack
            // 
            this.btnKundBack.Enabled = false;
            this.btnKundBack.Location = new System.Drawing.Point(552, 162);
            this.btnKundBack.Name = "btnKundBack";
            this.btnKundBack.Size = new System.Drawing.Size(59, 36);
            this.btnKundBack.TabIndex = 57;
            this.btnKundBack.Text = "Zurück";
            this.btnKundBack.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStatus.Location = new System.Drawing.Point(390, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(221, 20);
            this.lblStatus.TabIndex = 60;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxCon
            // 
            this.gBoxCon.Controls.Add(this.cBoxStatus);
            this.gBoxCon.Controls.Add(this.lblStatus);
            this.gBoxCon.Controls.Add(this.dTPCreated);
            this.gBoxCon.Controls.Add(this.btnKundBack);
            this.gBoxCon.Controls.Add(this.lblStandort);
            this.gBoxCon.Controls.Add(this.label10);
            this.gBoxCon.Controls.Add(this.txtKundEmail);
            this.gBoxCon.Controls.Add(this.txtKundLocation);
            this.gBoxCon.Controls.Add(this.lbl);
            this.gBoxCon.Controls.Add(this.txtKontaktID);
            this.gBoxCon.Controls.Add(this.label8);
            this.gBoxCon.Controls.Add(this.txtKundTel);
            this.gBoxCon.Controls.Add(this.label7);
            this.gBoxCon.Controls.Add(this.txtKundFax);
            this.gBoxCon.Controls.Add(this.lblName);
            this.gBoxCon.Controls.Add(this.btnAccept);
            this.gBoxCon.Controls.Add(this.lBoxCompany);
            this.gBoxCon.Controls.Add(this.label5);
            this.gBoxCon.Controls.Add(this.label4);
            this.gBoxCon.Controls.Add(this.cBoxKontakt);
            this.gBoxCon.Controls.Add(this.txtKundID);
            this.gBoxCon.Enabled = false;
            this.gBoxCon.Location = new System.Drawing.Point(12, 246);
            this.gBoxCon.Name = "gBoxCon";
            this.gBoxCon.Size = new System.Drawing.Size(623, 244);
            this.gBoxCon.TabIndex = 42;
            this.gBoxCon.TabStop = false;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.Enabled = false;
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(390, 138);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(221, 21);
            this.cBoxStatus.TabIndex = 94;
            this.cBoxStatus.Visible = false;
            // 
            // dTPCreated
            // 
            this.dTPCreated.Enabled = false;
            this.dTPCreated.Location = new System.Drawing.Point(390, 138);
            this.dTPCreated.Name = "dTPCreated";
            this.dTPCreated.Size = new System.Drawing.Size(221, 20);
            this.dTPCreated.TabIndex = 95;
            this.dTPCreated.ValueChanged += new System.EventHandler(this.dTPCreated_ValueChanged);
            // 
            // AuftragserstellungsTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 458);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.gBoxCon);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnMitBack);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnLastBack);
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
            this.Controls.Add(this.btnForward2);
            this.Controls.Add(this.btnBackward2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLChecked);
            this.Controls.Add(this.txtLGesammtPreis);
            this.Controls.Add(this.txtLPreis);
            this.Controls.Add(this.txtLMenge);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtLIDX);
            this.Controls.Add(this.checcheckBSaved);
            this.Controls.Add(this.btnWinCount);
            this.Controls.Add(this.btnRechnung);
            this.Controls.Add(this.btnProdukte);
            this.Controls.Add(this.btnLieferS);
            this.Controls.Add(this.btnBuchen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmMitarb);
            this.Controls.Add(this.lblGPreis);
            this.Controls.Add(this.txtGesammt);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.lblMitarb);
            this.Controls.Add(this.cBoxMitarb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.nUDPreis);
            this.Controls.Add(this.nUDMenge);
            this.Controls.Add(this.lblMenge);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cBoxProd);
            this.Controls.Add(this.cLBoxProd);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AuftragserstellungsTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuftragserstellungsTool_FormClosing);
            this.Load += new System.EventHandler(this.AuftragserstellungsTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPreis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gBoxCon.ResumeLayout(false);
            this.gBoxCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.ComboBox cBoxStatus;

        private System.Windows.Forms.TextBox txtKundID;
        public System.Windows.Forms.ComboBox cBoxKontakt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lBoxCompany;
        public System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtKundFax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKundTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKontaktID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtKundLocation;
        private System.Windows.Forms.TextBox txtKundEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStandort;
        private System.Windows.Forms.Button btnKundBack;
        public System.Windows.Forms.DateTimePicker dTPCreated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gBoxCon;

        private System.Windows.Forms.TextBox txtKundPosition;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtPasswd;

        private System.Windows.Forms.Button btnMitBack;

        private System.Windows.Forms.Button btnStatus;

        private System.Windows.Forms.Button btnLastBack;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label19;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMitEmail;
        private System.Windows.Forms.TextBox txtKundAbteilung;
        private System.Windows.Forms.TextBox txtMitUserName;
        private System.Windows.Forms.TextBox txtMitUUID;

        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnBackward2;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtLIDX;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtLMenge;
        private System.Windows.Forms.TextBox txtLPreis;
        private System.Windows.Forms.TextBox txtLGesammtPreis;

        public System.Windows.Forms.CheckedListBox cLBoxProd;
        public System.Windows.Forms.ComboBox cBoxProd;
        public System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblMenge;
        private System.Windows.Forms.NumericUpDown nUDMenge;
        private System.Windows.Forms.NumericUpDown nUDPreis;
        private System.Windows.Forms.Label lblPreis;
        public System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cBoxMitarb;
        private System.Windows.Forms.Label lblMitarb;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtGesammt;
        private System.Windows.Forms.Label lblGPreis;
        public System.Windows.Forms.Button btnConfirmMitarb;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuchen;
        private System.Windows.Forms.Button btnLieferS;
        private System.Windows.Forms.Button btnProdukte;
        private System.Windows.Forms.Button btnRechnung;
        private System.Windows.Forms.TextBox btnWinCount;
        private System.Windows.Forms.CheckBox checcheckBSaved;
        private System.Windows.Forms.TextBox txtLChecked;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;

        #endregion
    }
}