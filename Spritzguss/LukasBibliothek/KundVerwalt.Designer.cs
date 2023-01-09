using System.ComponentModel;

namespace LukasBibliothek
{
    partial class KundVerwalt
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
            this.btnH = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnKK = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnKKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnH
            // 
            this.btnH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnH.Location = new System.Drawing.Point(308, 162);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(180, 51);
            this.btnH.TabIndex = 0;
            this.btnH.Text = "Hauptmenü";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnK
            // 
            this.btnK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnK.Location = new System.Drawing.Point(308, 222);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(180, 51);
            this.btnK.TabIndex = 1;
            this.btnK.Text = "Kunden";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnKK
            // 
            this.btnKK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKK.Location = new System.Drawing.Point(308, 338);
            this.btnKK.Name = "btnKK";
            this.btnKK.Size = new System.Drawing.Size(180, 51);
            this.btnKK.TabIndex = 2;
            this.btnKK.Text = "KundenKontakt ";
            this.btnKK.UseVisualStyleBackColor = true;
            this.btnKK.Click += new System.EventHandler(this.btnKK_Click);
            // 
            // btnKH
            // 
            this.btnKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKH.Location = new System.Drawing.Point(308, 280);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(180, 51);
            this.btnKH.TabIndex = 3;
            this.btnKH.Text = "Kunden Hinzufügen";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnKKH
            // 
            this.btnKKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKKH.Location = new System.Drawing.Point(308, 398);
            this.btnKKH.Name = "btnKKH";
            this.btnKKH.Size = new System.Drawing.Size(180, 51);
            this.btnKKH.TabIndex = 4;
            this.btnKKH.Text = "KundenKontakt Hinzufügen";
            this.btnKKH.UseVisualStyleBackColor = true;
            this.btnKKH.Click += new System.EventHandler(this.btnKKH_Click);
            // 
            // KundVerwalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 609);
            this.Controls.Add(this.btnKKH);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnKK);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnH);
            this.DoubleBuffered = true;
            this.Name = "KundVerwalt";
            this.Text = "KundVerwalt";
            this.Load += new System.EventHandler(this.KundVerwalt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnKK;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnKKH;
    }
}