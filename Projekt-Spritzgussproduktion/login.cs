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
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Projekt.accdb";
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Projekt.accdb";
                    con.Open();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                throw;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Mitarbeiter", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            username = dr["MitUserName"].ToString();
            passwd = dr["MitUserPasswd"].ToString();
            
            if (txtUName.Text == username && txtPasswd.Text == passwd)
            {
                Home home = new Home();
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("A user with this username and/ or password didn't exist!");
                txtPasswd.Text = "";
            }
        }

        private void txtPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}