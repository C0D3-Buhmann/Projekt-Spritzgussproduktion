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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBSchritt = new System.Windows.Forms.ComboBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lBRoh = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBAutrag = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.nUDMenge = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.btnAuftrNeu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBSchritt);
            this.groupBox1.Controls.Add(this.txtProID);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lBRoh);
            this.groupBox1.Location = new System.Drawing.Point(249, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 339);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
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
            this.txtProID.Text = "ProID";
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Gesammt";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(295, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rohstoff\r\nVerbrauchsmenge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Stk";
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(693, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 28);
            this.button5.TabIndex = 15;
            this.button5.Text = "Produktverwaltung";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Rohstoffverwaltung";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Preis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Menge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBAutrag
            // 
            this.cBAutrag.FormattingEnabled = true;
            this.cBAutrag.Location = new System.Drawing.Point(18, 11);
            this.cBAutrag.Name = "cBAutrag";
            this.cBAutrag.Size = new System.Drawing.Size(149, 21);
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
            // 
            // nUDMenge
            // 
            this.nUDMenge.Location = new System.Drawing.Point(88, 38);
            this.nUDMenge.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nUDMenge.Name = "nUDMenge";
            this.nUDMenge.Size = new System.Drawing.Size(155, 20);
            this.nUDMenge.TabIndex = 27;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(693, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 28);
            this.button10.TabIndex = 28;
            this.button10.Text = "Auftrag Buchen";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnAuftrNeu
            // 
            this.btnAuftrNeu.Location = new System.Drawing.Point(12, 98);
            this.btnAuftrNeu.Name = "btnAuftrNeu";
            this.btnAuftrNeu.Size = new System.Drawing.Size(231, 28);
            this.btnAuftrNeu.TabIndex = 29;
            this.btnAuftrNeu.Text = "Neu Anlegen";
            this.btnAuftrNeu.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 64);
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
            this.btnExit.Location = new System.Drawing.Point(693, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 27);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AuftragsVerwalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAuftrNeu);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.nUDMenge);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBAutrag);
            this.Controls.Add(this.groupBox1);
            this.Name = "AuftragsVerwalt";
            this.Text = "AuftragsVerwalt";
            this.Load += new System.EventHandler(this.AuftragsVerwalt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenge)).EndInit();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.ComboBox cBSchritt;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox txtProID;

        private System.Windows.Forms.Button btnAuftrNeu;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button button10;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cBAutrag;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.NumericUpDown nUDMenge;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lBRoh;

        #endregion
    }
}