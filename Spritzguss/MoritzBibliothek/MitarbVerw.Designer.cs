using System.ComponentModel;

namespace MoritzBibliothek
{
    partial class MitarbVerw
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
            this.lBoxMitarbID = new System.Windows.Forms.ListBox();
            this.checkBDeleted = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAuftrNeu = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxMitarbID
            // 
            this.lBoxMitarbID.FormattingEnabled = true;
            this.lBoxMitarbID.Location = new System.Drawing.Point(11, 9);
            this.lBoxMitarbID.Name = "lBoxMitarbID";
            this.lBoxMitarbID.Size = new System.Drawing.Size(207, 394);
            this.lBoxMitarbID.TabIndex = 0;
            // 
            // checkBDeleted
            // 
            this.checkBDeleted.Location = new System.Drawing.Point(41, 410);
            this.checkBDeleted.Name = "checkBDeleted";
            this.checkBDeleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBDeleted.Size = new System.Drawing.Size(100, 22);
            this.checkBDeleted.TabIndex = 19;
            this.checkBDeleted.Text = "Gelöscht";
            this.checkBDeleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBDeleted.UseVisualStyleBackColor = true;
            this.checkBDeleted.CheckedChanged += new System.EventHandler(this.checkBDeleted_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(673, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 28);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAuftrNeu
            // 
            this.btnAuftrNeu.Location = new System.Drawing.Point(673, 373);
            this.btnAuftrNeu.Name = "btnAuftrNeu";
            this.btnAuftrNeu.Size = new System.Drawing.Size(115, 28);
            this.btnAuftrNeu.TabIndex = 32;
            this.btnAuftrNeu.Text = "Neu Anlegen";
            this.btnAuftrNeu.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(673, 339);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 28);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Ändern";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // MitarbVerw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAuftrNeu);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.checkBDeleted);
            this.Controls.Add(this.lBoxMitarbID);
            this.Name = "MitarbVerw";
            this.Text = "MitarbVerw";
            this.Load += new System.EventHandler(this.MitarbVerw_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAuftrNeu;
        private System.Windows.Forms.Button btnChange;

        private System.Windows.Forms.CheckBox checkBDeleted;

        private System.Windows.Forms.ListBox lBoxMitarbID;

        #endregion
    }
}