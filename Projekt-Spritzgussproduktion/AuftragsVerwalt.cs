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
        private bool create, edit, delete;
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
            change();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Exit")
            {
                Close();
            }
            else if (btnExit.Text == "Abbruch")
            {
                btnAuftrBuchen.Enabled = false;
                btnDelete.Visible = true;
                btnAuftrNeu.Visible = true;
                btnChange.Visible = true;
            
                btnDelete.Enabled = true;
                btnAuftrNeu.Enabled = true;
                btnChange.Enabled = true;

                groupAuftrVerwalt.Visible = false;
                groupInfo.Visible = true;
            
                nUDMenge.Visible = true;
                lblMenge.Visible = true;
                lblPreis.Visible = true;
            
                btnRohVerw.Visible = true;
                btnProdVerw.Visible = true;
            
                btnExit.Text = "Exit";
            }
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
                lblPreis.Text = (Convert.ToDecimal(dr["PreisProStk"]) * nUDMenge.Value).ToString();
            }
            catch
            {
            }
        }

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
            create = true;
            btnAccept.Text = "Create";
            groupAuftrVerwalt.Visible = true;
            groupInfo.Visible = false;
            btnDelete.Visible = false;
            btnChange.Visible = false;
            btnAuftrNeu.Enabled = false;
            nUDMenge.Visible = false;
            lblMenge.Visible = false;
            lblPreis.Visible = false;

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
            edit = true;
            btnAccept.Text = "Change";
            groupAuftrVerwalt.Visible = true;
            groupInfo.Visible = false;
            btnDelete.Visible = false;
            btnAuftrNeu.Visible = false;
            btnChange.Enabled = false;
            nUDMenge.Visible = false;
            lblMenge.Visible = false;
            lblPreis.Visible = false;
            btnRohVerw.Visible = false;
            btnProdVerw.Visible = false;
            
            change();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete = true;
            btnAccept.Text = "Delete";
            groupAuftrVerwalt.Visible = true;
            groupInfo.Visible = false;
            btnAuftrNeu.Visible = false;
            btnChange.Visible = false;
            btnDelete.Enabled = false;
            nUDMenge.Visible = false;
            lblMenge.Visible = false;
            lblPreis.Visible = false;
            btnRohVerw.Visible = false;
            btnProdVerw.Visible = false;
        }


        private void change()
        {
            
            cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBAutrag.Text}", con);
            dr = cmd.ExecuteReader();
            dr.Read();

            try
            {
                nUDMengeN.Update();
                nUDPreisN.Update();
                nUDMengeN.Value = Convert.ToDecimal(dr["Menge"].ToString());
                nUDPreisN.Value = Convert.ToDecimal(dr["PreisProStk"].ToString());
                lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
            }
            catch
            {
            }
            
            try
            {
                cmd = new OleDbCommand($"select * from FirmenKontakt, Auftrag where AuftragsID={cBAutrag.Text} and AuftrKontaktID=KontaktID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActContact = dr["KontaktID"].ToString();
                
                cmd = new OleDbCommand($"select * from FirmenKontakt", con);
                dr = cmd.ExecuteReader();
                cBoxKontakt.Update();
                cBoxKontakt.Text = "";
                cBoxKontakt.Items.Clear();
                while (dr.Read())
                {
                    cBoxKontakt.Items.Add(dr["KontaktID"].ToString());
                }
                cBoxKontakt.SelectedText = ActContact;
                cBoxKontakt.EndUpdate();
            }
            catch
            {
            }

            try
            {
                cmd = new OleDbCommand($"select * from Mitarbeiter, Auftrag where AuftragsID={cBAutrag.Text} and AuftrZMitID=MitUUID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActualMitarb = dr["MitName"].ToString();
                
                cmd = new OleDbCommand($"select * from Mitarbeiter", con);
                dr = cmd.ExecuteReader();
                cBoxMitarb.Update();
                cBoxMitarb.Text = "";
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
                cBoxProd.Text = "";
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
                cBoxStatus.Text = "";
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

        private void nUDMenge_ValueChanged(object sender, EventArgs e)
        {
            var PAuftrID = cBAutrag.Text;
            cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID={Convert.ToInt32(PAuftrID)}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            lblPreis.Text = (Convert.ToDecimal(dr["PreisProStk"]) * nUDMenge.Value).ToString();
        }

        private void nUDMengeN_ValueChanged(object sender, EventArgs e)
        {
            lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
        }

        private void nUDPreisN_ValueChanged(object sender, EventArgs e)
        {
            lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnAuftrBuchen.Enabled = true;
            groupAuftrVerwalt.Enabled = false;
        }

        private void btnAuftrBuchen_Click(object sender, EventArgs e)
        {
            if (create)
            {
                
            }
            else if (edit)
            {
                
            }
            else if (delete)
            {
                
            }
            else
            {
                
            }
            
            
            btnAuftrBuchen.Enabled = false;
            btnDelete.Visible = true;
            btnAuftrNeu.Visible = true;
            btnChange.Visible = true;
            
            btnDelete.Enabled = true;
            btnAuftrNeu.Enabled = true;
            btnChange.Enabled = true;

            groupAuftrVerwalt.Visible = false;
            groupInfo.Visible = true;
            
            nUDMenge.Visible = true;
            lblMenge.Visible = true;
            lblPreis.Visible = true;
            
            btnRohVerw.Visible = true;
            btnProdVerw.Visible = true;
            
            btnExit.Text = "Abbruch";
        }
    }
}