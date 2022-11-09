using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public partial class AuftragsStatus : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public AuftragsStatus()
        {
            InitializeComponent();
        }

        private void AuftragsStatus_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from SchrittRohVerb", con);
            ds.Clear();
            DataAdapt.Fill(ds, "SchrittRohVerb");
            dGView.DataSource = ds;
            dGView.DataMember = "SchrittRohVerb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from ProduktSchritte", con);
            ds.Clear();
            DataAdapt.Fill(ds, "ProduktSchritte");
            dGView.DataSource = ds;
            dGView.DataMember = "ProduktSchritte";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Preisliste", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Kunden");
            dGView.DataSource = ds;
            dGView.DataMember = "Kunden";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Produkt", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Produkt");
            dGView.DataSource = ds;
            dGView.DataMember = "Produkt";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Rohstoffe", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Rohstoffe");
            dGView.DataSource = ds;
            dGView.DataMember = "Rohstoffe";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Auftrag", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Auftrag");
            dGView.DataSource = ds;
            dGView.DataMember = "Auftrag";
        }
    }
}