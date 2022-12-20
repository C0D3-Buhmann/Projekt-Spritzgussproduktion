using System;
using System.Windows.Forms;

namespace MoritzBibliothek
{
    public partial class UserVerwalt : Form
    {
        public bool erstellen, bearbeiten, wiederherstellen, löschen;
        public UserVerwalt()
        {
            InitializeComponent();
        }

        private void UserVerwalt_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            erstellen = true;
            if (erstellen = true)
            {
                switch (btnCreate.Text)
                {
                    case "Erstellen":
                        btnCreate.Text = "Wiederherstellen";
                        btnEdit.Visible = false;
                        btnDelete.Text = "Speichern";
                        btnDelete.Enabled = false;
                        cBoxUser.Enabled = false;
                        txtPasswd.Enabled = true;
                        txtPasswd2.Enabled = true;
                        txtUName.Enabled = true;
                        txtPasswd.Visible = true;
                        txtPasswd2.Visible = true;
                        txtUName.Visible = true;
                        break;
                    case "Wiederherstellen":
                        wiederherstellen = true;
                        break;
                    default: 
                        break;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bearbeiten = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            löschen = true;
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            txtPasswd.PasswordChar = '*';
        }

        private void txtPasswd2_TextChanged(object sender, EventArgs e)
        {
            txtPasswd2.PasswordChar = '*';
            if (txtPasswd.Text == txtPasswd2.Text)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void txtUName_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == "Username")
            {
                txtUName.Text = "";
            }
        }

        private void txtPasswd_Click(object sender, EventArgs e)
        {
            if (txtPasswd.Text == "Password")
            {
                txtPasswd.Text = "";
            }
        }

        private void txtPasswd2_Click(object sender, EventArgs e)
        {
            if (txtPasswd2.Text == "Confirm Password")
            {
                txtPasswd2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}