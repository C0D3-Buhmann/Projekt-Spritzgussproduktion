using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public partial class AuftragsVerwalt : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public AuftragsVerwalt()
        {
            InitializeComponent();
        }

        private void AuftragsVerwalt_Load(object sender, EventArgs e)
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

            cmd = new OleDbCommand("select * from Auftrag", con);
            dr = cmd.ExecuteReader();

            cBAutrag.Update();
            cBAutrag.Items.Clear();
            while (dr.Read())
            {
                cBAutrag.Items.Add(dr["AuftragsID".ToString()]);
            }
            cBAutrag.SelectedIndex = 0;
            cBAutrag.EndUpdate();
            load();
            cmd = new OleDbCommand("select * from ProduktSchritte, SchrittRohVerb, Preisliste, Produkt, Auftrag where AuftragsID=PAuftrID and PProID=ProID and ProID=SProID and SchrittID=RSchrittID", con);
            dr = cmd.ExecuteReader();
            cBSchritt.Update();
            cBSchritt.Items.Clear();
            while (dr.Read())
            {
                cBSchritt.Items.Add(dr["SchrittID".ToString()]);
            }
            cBSchritt.SelectedIndex = 0;
            cBSchritt.EndUpdate();
            
            fillRoh();
        }


        private void cBAutrag_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            try
            {
                var PAuftrID = cBAutrag.Text;
                cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID={Convert.ToInt32(PAuftrID)}", con);
                dr = cmd.ExecuteReader();
                dr.Read();

                //MessageBox.Show(dr["Menge".ToString()].ToString());
                nUDMenge.Update();
                nUDMenge.Value = Convert.ToDecimal(dr["Menge".ToString()].ToString());
            
                string auftragsid = cBAutrag.Text;
                cmd = new OleDbCommand($"select * from Auftrag, Preisliste where PAutrID={Convert.ToInt32(auftragsid)}", con);
                var AuftagsID = dr["AuftagsID"];
                txtProID.Text = dr["PProID"].ToString();
            }
            catch
            {
            }
        }

        /*private void fillRoh()
        {
            //cmd = new OleDbCommand("select SRohVID from Auftrag, ProduktSchritte, SchrittRohVerb", con);
            cmd = new OleDbCommand($"SELECT SRohVID, SProID FROM ProduktSchritte, SchrittRohVerb WHERE (SProID={Convert.ToInt32(txtProID.Text)})", con);
            cmd.ExecuteReader();
            try
            {
                
                cBSchritt.Update();
                cBSchritt.Items.Clear();
                while (dr.Read())
                {
                    cBSchritt.Items.Add(dr["SRohVID".ToString()]);
                }
                cBSchritt.EndUpdate();
            
                
            }
            catch
            {
                lBRoh.Update();
                lBRoh.Items.Clear();
                while (dr.Read())
                {
                    lBRoh.Items.Add(dr["SRohVID".ToString()]);
                }
                lBRoh.EndUpdate();
            }
        }*/

        public void fillRoh()
        {
            cmd = new OleDbCommand("select SRohVID from ProduktSchritte, SchrittRohVerb", con);
            dr = cmd.ExecuteReader();
            
            lBRoh.Update();
            lBRoh.Items.Clear();
            while (dr.Read())
            {
                lBRoh.Items.Add(dr["SRohVID".ToString()]);
            }
            lBRoh.EndUpdate();
        }

        private void btnAuftrNeu_Click(object sender, EventArgs e)
        {
            btnAccept.Text = "Create";
            groupAuftrVerwalt.Visible = true;

            try
            {
                cmd = new OleDbCommand($"select * from FirmenKontakt", con);
                dr = cmd.ExecuteReader();
                cBoxKontakt.Update();
                cBoxKontakt.Items.Clear();
                while (dr.Read())
                {
                    cBoxKontakt.Items.Add(dr["KontaktID".ToString()]);
                }
                cBoxKontakt.EndUpdate();
            }
            catch
            {
            }

            try
            {
                cmd = new OleDbCommand($"select * from Mitarbeiter", con);
                dr = cmd.ExecuteReader();
                cBoxMitarb.Update();
                cBoxMitarb.Items.Clear();
                while (dr.Read())
                {
                    cBoxMitarb.Items.Add(dr["MitName".ToString()]);
                }
                cBoxMitarb.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                cmd = new OleDbCommand($"select * from Produkt", con);
                dr = cmd.ExecuteReader();
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                while (dr.Read())
                {
                    cBoxProd.Items.Add(dr["ProName".ToString()]);
                }
                cBoxProd.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                cmd = new OleDbCommand($"select * from Status", con);
                dr = cmd.ExecuteReader();
                cBoxStatus.Update();
                cBoxStatus.Items.Clear();
                while (dr.Read())
                {
                    cBoxStatus.Items.Add(dr["Statusmeldung".ToString()]);
                }
                cBoxStatus.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                /*cmd = new OleDbCommand($"select AuftragsDat from Auftrag", con);
                dr = cmd.ExecuteReader();
                dr.Read();*/
                dTPCreated.Value = DateTime.Now;
            }
            catch
            {
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnAccept.Text = "Change";
            groupAuftrVerwalt.Visible = true;
            
            try
            {
                cmd = new OleDbCommand($"select * from FirmenKontakt, Auftrag where AuftragsID={cBAutrag.Text} and AuftrKontaktID", con);
                dr = cmd.ExecuteReader();
                
                cmd = new OleDbCommand($"select * from FirmenKontakt", con);
                dr = cmd.ExecuteReader();
                cBoxKontakt.Update();
                cBoxKontakt.Items.Clear();
                while (dr.Read())
                {
                    cBoxKontakt.Items.Add(dr["KontaktID"].ToString());
                }
                cBoxKontakt.EndUpdate();
            }
            catch
            {
            }

            try
            {
                cmd = new OleDbCommand($"select * from Mitarbeiter, Auftrag where AuftragsID={cBAutrag.Text} and AuftrZMidID=MitUUID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActualMitarb = dr["MitName"].ToString();
                
                cmd = new OleDbCommand($"select * from Mitarbeiter", con);
                dr = cmd.ExecuteReader();
                cBoxMitarb.Update();
                cBoxMitarb.Items.Clear();
                while (dr.Read())
                {
                    cBoxMitarb.Items.Add(dr["MitName"].ToString());
                }
                cBoxMitarb.SelectedText = ActualMitarb;
                cBoxMitarb.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                
                cmd = new OleDbCommand($"select * from Produkt, Preisliste, Auftrag where AuftragsID={cBAutrag.Text} and AuftragsID=PAuftrID and PProID=ProID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActualProduct = dr["ProName"].ToString();
                
                cmd = new OleDbCommand($"select * from Produkt", con);
                dr = cmd.ExecuteReader();
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                while (dr.Read())
                {
                    cBoxProd.Items.Add(dr["ProName"].ToString());
                }

                cBoxProd.SelectedText = ActualProduct;
                cBoxProd.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                cmd = new OleDbCommand($"select * from Status, Auftrag where AuftragsID={cBAutrag.Text} and Auftragsstatus=StatusID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActualStatus = dr["Statusmeldung"].ToString();
                
                cmd = new OleDbCommand($"select * from Status", con);
                dr = cmd.ExecuteReader();
                cBoxStatus.Update();
                cBoxStatus.Items.Clear();
                while (dr.Read())
                {
                    cBoxStatus.Items.Add(dr["Statusmeldung"].ToString());
                }
                cBoxStatus.SelectedText = ActualStatus;
                cBoxStatus.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                cmd = new OleDbCommand($"select * from Auftrag where AuftragsID={cBAutrag.Text}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                dTPCreated.Value = Convert.ToDateTime(dr["AuftragsDat".ToString()]);
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAccept.Text = "Delete";
        }
    }
}