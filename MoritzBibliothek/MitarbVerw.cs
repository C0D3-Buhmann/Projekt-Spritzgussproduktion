using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MoritzBibliothek
{
    public partial class MitarbVerw : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private bool create, edit, delete;
        public MitarbVerw()
        {
            InitializeComponent();
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
            cmd = new OleDbCommand("select * from Mitarbeiter", con);
            dr = cmd.ExecuteReader();

            lBoxMitarbID.Update();
            lBoxMitarbID.Items.Clear();
            while (dr.Read())
            {
                lBoxMitarbID.Items.Add(dr["MitUUID".ToString()]);
            }
            lBoxMitarbID.SelectedIndex = 0;
            lBoxMitarbID.EndUpdate();
        }
        private void MitarbVerw_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void checkBDeleted_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

    }
}