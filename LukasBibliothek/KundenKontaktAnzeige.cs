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


namespace LukasBibliothek
{
    public partial class KundenKontaktAnzeige : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public KundenKontaktAnzeige()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KundenKontaktAnzeige_Load(object sender, EventArgs e)
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
                MessageBox.Show(E.Message);
            }
            try
            {
                cmd = new OleDbCommand("select * FROM KundenKontakt", con);
                dr = cmd.ExecuteReader();
                cBoxKKID.Update();
                cBoxKKID.Items.Clear();
                while (dr.Read())
                {
                    cBoxKKID.Items.Add(dr["KKID"].ToString());
                }




            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message);
                throw;
            }
        }
    }
}
