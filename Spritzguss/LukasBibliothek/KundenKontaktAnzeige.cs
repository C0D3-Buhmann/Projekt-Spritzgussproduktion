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
            this.Close();
            con.Close();

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
                cmd = new OleDbCommand($"select * FROM FirmenKontakt ", con);
                dr = cmd.ExecuteReader();
                cBoxK.Update();
                cBoxK.Items.Clear();
                while (dr.Read())
                {
                    cBoxK.Items.Add(dr["KKInfo"].ToString());
                }
                cBoxK.SelectedIndex = 0;
                cBoxK.EndUpdate();
            }
            catch (Exception E2)
            {
                MessageBox.Show(E2.Message);
                throw;
            }

            try
            {
                cmd = new OleDbCommand($"Select * From Kunden, FirmenKontakt where {cBoxKKID.Text} = KontaktID and KundID ", con);
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

            try
            {
                cmd = new OleDbCommand($"Select * From Auftrag where {cBoxKKID.Text} = AuftrKontaktID", con);
                dr = cmd.ExecuteReader();
                comboBox3.Update();
                comboBox3.Items.Clear();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["AuftragsID"].ToString());
                }
                comboBox3.SelectedIndex = 0;
                comboBox3.EndUpdate();
            }
            catch (Exception E4)
            {
                MessageBox.Show(E4.Message);
                throw;
            }

            try
            {
                cmd = new OleDbCommand($"select * from Firmenkontakt where {cBoxKKID.Text} = KontaktID ", con);
                dr = cmd.ExecuteReader();
                textBox2.Update();
                textBox2.Clear();
                textBox4.Update();
                textBox4.Clear();
                textBox5.Update();
                textBox5.Clear();
                textBox6.Update();
                textBox6.Clear();
                textBox7.Update();
                textBox7.Clear();
                textBox1.Update();
                textBox1.Clear();
                while (dr.Read())
                {
                    textBox2.Text = dr["KKInfo"].ToString();
                    textBox1.Text = dr["KontaktRechnAdr"].ToString();
                    textBox4.Text = dr["KontaktTel"].ToString();
                    textBox5.Text = dr["KontaktFTel"].ToString();
                    textBox6.Text = dr["KontaktEmail"].ToString();
                    textBox7.Text = dr["AnsprechID"].ToString();
                }

            }
            catch (Exception E5)
            {
                MessageBox.Show(E5.Message);
                throw;
            }


        }

        private void cBoxK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception E6)
            {
                MessageBox.Show(E6.Message);
                throw;
            }

            try
            {
                cmd = new OleDbCommand($"select * KontaktID where KontaktID = {cBoxK} = KontaktID", con);
            }
            catch (Exception E7)
            {
                MessageBox.Show(E7.Message);
                throw;
            }

            // con.Close();
        }

        private void cBoxKKID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
