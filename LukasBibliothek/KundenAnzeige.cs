using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukasBibliothek
{
    public partial class KundenAnzeige : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public KundenAnzeige()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KundenAnzeige_Load(object sender, EventArgs e)
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
                Kundenverbindung(sender, e);
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
                throw;
            }
        }
        private void Kundenverbindung(object sender, EventArgs e)
        {

            try
            {
                cmd = new OleDbCommand("select KundID from Kunden", con);
                dr = cmd.ExecuteReader();
                cBoxKID.Update();
                cBoxKID.Items.Clear();
                while (dr.Read())
                {
                    cBoxKID.Items.Add(dr["KundID"].ToString());
                }
                cBoxKID.SelectedIndex = 0;
                cBoxKID.EndUpdate();

            }
            catch (Exception E4)
            {
                MessageBox.Show(E4.ToString());
                throw;
            }
            try
            {
                cmd = new OleDbCommand($"select * from Kunden where {cBoxKID.Text}=KundID", con);
                dr = cmd.ExecuteReader();
                cBoxK.Update();
                cBoxK.Items.Clear();
                while (dr.Read())
                {
                    cBoxK.Items.Add(dr["KundFName"].ToString());
                }
                cBoxK.SelectedIndex = 0;
                cBoxK.EndUpdate();

            }
            catch (Exception E3)
            {
                MessageBox.Show(E3.ToString());
                throw;
            }
            try
            {
                cmd = new OleDbCommand($"select AuftragsID from Auftrag where {cBoxKID.Text}=AuftrZMitID", con);
                dr = cmd.ExecuteReader();
                cBoxAID.Update();
                cBoxAID.Items.Clear();
                while (dr.Read())
                {
                    cBoxAID.Items.Add(dr["AuftragsID"].ToString());
                }
                cBoxAID.SelectedIndex = 0;
                cBoxAID.EndUpdate();
            }
            catch (Exception E5)
            {
                MessageBox.Show(E5.ToString());
                throw;
            }
            try
            {
                try
                {
                    cmd = new OleDbCommand($"select * from Kunden where {cBoxKID.Text}=KundID", con);
                    dr = cmd.ExecuteReader();
                    lblHQ.Update();
                    lblST.Update();
                    lblSF.Update();
                    lblSE.Update();
                    while (dr.Read())
                    {
                        lblHQ.Text = dr["KundHQOrt"].ToString();
                        //cBoxKK.Items.Add(dr["HQ"].ToString());
                        lblST.Text = dr["KundSupTel"].ToString();
                        lblSF.Text = dr["KundFSupTel"].ToString();
                        lblSE.Text = dr["KundSupEmail"].ToString();

                    }
                }
                catch (Exception E7)
                {
                    MessageBox.Show(E7.ToString());
                    throw;
                }

                try
                {
                    cmd = new OleDbCommand($"select KKInfo from FirmenKontakt where {cBoxKID.Text}=KKundID", con);
                    dr = cmd.ExecuteReader();
                    cBoxKK.Update();
                    cBoxKK.Items.Clear();
                    while (dr.Read())
                    {
                        cBoxKK.Items.Add(dr["KKInfo"].ToString());
                    }
                    cBoxKK.SelectedIndex = 0;
                    cBoxKK.EndUpdate();
                }
                catch (Exception E9)
                {
                    MessageBox.Show(E9.ToString());
                    throw;
                }



            }
            catch (Exception E6)
            {
                MessageBox.Show(E6.ToString());
                throw;
            }
            /*try
            {
                con.Close();
            }
            catch (Exception E8)
            {
                MessageBox.Show(E8.ToString());
                throw;
            }*/
        }
        private void cBoxK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Kundenverbindung(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;

            }
        }

    }
}
