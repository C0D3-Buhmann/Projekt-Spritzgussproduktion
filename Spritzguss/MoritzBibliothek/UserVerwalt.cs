using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MoritzBibliothek
{
    public partial class UserVerwalt : Form
    {
        public bool contains;
        public OleDbConnection con = new OleDbConnection();
        public OleDbDataReader dr;
        public OleDbCommand cmd;
        public int CountIDX, idx, KontaktID, MitarbeiterID, StatusID, AuftragsID, ProID, AuftrID;
        public static int checkMode;
        public string user, passwd, username_old;

        public bool erstellen, bearbeiten, wiederherstellen, löschen;
        public UserVerwalt()
        {
            InitializeComponent();
        }

        private void UserVerwalt_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=ProjektX.accdb";
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjektX.accdb";
                    con.Open();
                }
            }
            catch
            {
            }
            cmd = new OleDbCommand("Select MitUserName from Mitarbeiter where gelöscht=false", con);
            dr = cmd.ExecuteReader();

            cBoxUser.BeginUpdate();
            cBoxUser.Update();
            cBoxUser.Items.Clear();
            while (dr.Read())
            {
                cBoxUser.Update();
                cBoxUser.Items.Add(dr["MitUserName"].ToString());
            }
            cBoxUser.SelectedIndex = 0;
            cBoxUser.EndUpdate();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            erstellen = true;
            if (erstellen = true)
            {
                switch (btnCreate.Text)
                {
                    case "Erstellen":
                        Mode();
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
            Mode();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                löschen = true;
                Mode();
            }
            else
            {
                if (erstellen)
                {
                    cmd = new OleDbCommand($"insert into Mitarbeiter (MitUserName, MitUserPasswd, MitAbtID, MitPosID) values (MitUserName='{txtUName.Text}', MitUserPasswd='{txtPasswd2.Text}', 2, 2) ", con);
                    cmd.ExecuteNonQuery();
                }
                else if (löschen)
                {
                    cmd = new OleDbCommand($"update Mitarbeiter set gelöscht=true where MitUserName='{txtUName.Text}'", con);
                    cmd.ExecuteNonQuery();
                }
                else if (bearbeiten)
                {
                    
                    user = txtUName.Text;
                    passwd = txtPasswd2.Text;
                    MessageBox.Show((username_old + "\n" + user + "\n" + passwd).ToString());
                    cmd = new OleDbCommand(
                        $"update Mitarbeiter set MitUserPasswd='{passwd}', MitUserName='{user}' where mitUserName='{username_old}'",
                        con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            txtPasswd.PasswordChar = '*';
        }

        private void txtPasswd2_TextChanged(object sender, EventArgs e)
        {
            txtPasswd2.PasswordChar = '*';
            if (txtPasswd.Text == txtPasswd2.Text && txtUName.Text != "")
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }

            passwd = txtPasswd.Text;
        }

        private void txtUName_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == "Username")
            {
                txtUName.Text = "";
            }
            user = txtUName.Text;
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

        private void Mode()
        {
            if (bearbeiten)
            {
                cBoxUser.Enabled = false;
                txtUName.Visible = true;
                txtPasswd.Visible = true;
                txtPasswd2.Visible = true;
                txtPasswd.Enabled = true;
                txtPasswd2.Enabled = true;
                btnDelete.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Text = "Speichern";
                btnDelete.Enabled = false;
                txtUName.Enabled = true;
                
                cmd = new OleDbCommand($"Select * from Mitarbeiter where MitUserName='{cBoxUser.Text}'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                
                txtUName.Text = dr["MitUserName"].ToString();
            }
            else if (erstellen)
            {
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
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Visible = false;
                btnDelete.Text = "Löschen";
                btnDelete.Enabled = false;
                cBoxUser.Enabled = false;
                txtPasswd.Enabled = true;
                txtPasswd2.Enabled = true;
                txtUName.Enabled = false;
                txtPasswd.Visible = true;
                txtPasswd2.Visible = true;
                txtUName.Visible = true;
                
                cmd = new OleDbCommand($"Select * from Mitarbeiter where MitUserName='{cBoxUser.Text}'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                
                txtUName.Text = dr["MitUserName"].ToString();
            }
        }

        private void cBoxUser_TextChanged(object sender, EventArgs e)
        {
            username_old = cBoxUser.Text;
        }
    }
}