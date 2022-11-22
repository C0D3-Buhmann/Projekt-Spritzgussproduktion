using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt_Spritzgussproduktion.configuration;

namespace Projekt_Spritzgussproduktion
{
    public partial class Form1 : Form
    { 
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public string passwd, username;
        public int userID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                throw;
            }
        }
        public void ConCheck()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConCheck();
            cmd = new OleDbCommand($"select * from Mitarbeiter where MitUserName='{txtUName.Text}'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            username = dr["MitUserName"].ToString();
            passwd = dr["MitUserPasswd"].ToString();
            userID = Convert.ToInt32(dr["MitUUID"].ToString());
            
            if (txtUName.Text == username && txtPasswd.Text == passwd)
            {
                HomeMenu home = new HomeMenu();
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("A user with this username and/ or password didn't exist!");
                txtPasswd.Text = "";
            }
            con.Close();
        }

        

        private void txtPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            ConCheck();
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}