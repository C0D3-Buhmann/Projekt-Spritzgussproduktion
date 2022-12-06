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
                throw;
            }
            try
            {
                cmd = new OleDbCommand("select * FROM FirmenKontakt", con);
                dr = cmd.ExecuteReader();
                cBoxKKID.Update();
                cBoxKKID.Items.Clear();
                while (dr.Read())
                {
                    cBoxKKID.Items.Add(dr["KontaktID"].ToString());


                }
                cBoxKKID.SelectedIndex = 0;
                cBoxKKID.EndUpdate();
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message);
                throw;
            }
            try
            {
                cmd = new OleDbCommand($"select * FROM FirmenKontakt where {cBoxKKID.Text} = KontaktID", con);
                dr = cmd.ExecuteReader();
                cBoxK.Update();
                cBoxK.Items.Clear();
                while (dr.Read())
                {
                    cBoxK.Items.Add(dr["KKInfo"].ToString());
                }
                cBoxKKID.SelectedIndex = 0;
                cBoxKKID.EndUpdate();
            }
            catch (Exception E2)
            {
                MessageBox.Show(E2.Message);
                throw;
            }

            try
            {
                cmd = new OleDbCommand($"Select * From Kunden, FirmenKontakt where {cBoxKKID.Text} = KontaktID and KundID =KKundID ", con);
                dr = cmd.ExecuteReader();
                comboBox2.Update();
                comboBox2.Items.Clear();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["KundID"].ToString());
                }
                comboBox2.SelectedIndex = 0;
                comboBox2.EndUpdate();
            }
            catch (Exception E3)
            {
                MessageBox.Show(E3.Message);
                throw;
            }
        }
    }
}
