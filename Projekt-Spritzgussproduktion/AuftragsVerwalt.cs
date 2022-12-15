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
        public static bool create, edit, view, delete, finished;

        public static int Auftrag {get; set;}
        
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
            
            try
            {
                lBoxCompany.BeginUpdate();
                cmd = new OleDbCommand("select * from Kunden", con);
                dr = cmd.ExecuteReader();
                lBoxCompany.Update();
                lBoxCompany.Items.Clear();
                while (dr.Read())
                {
                    lBoxCompany.Update();
                    lBoxCompany.Items.Add(dr["KundFName".ToString()]);
                }
                lBoxCompany.SelectedIndex = 0;
                lBoxCompany.EndUpdate();
                
                
                cBoxKont.BeginUpdate();
                cmd = new OleDbCommand($"select * from FirmenKontakt, kunden where KundFName='{lBoxCompany.Text}' and KKundID=KundID", con);
                dr = cmd.ExecuteReader();
                cBoxKont.Update();
                cBoxKont.Items.Clear();
                while (dr.Read())
                {
                    cBoxKont.Update();
                    cBoxKont.Items.Add(dr["KKInfo".ToString()]);
                }
                cBoxKont.SelectedIndex = 0;
                cBoxKont.EndUpdate();
            }
            catch
            {
            }
            
            try
            {
                cBoxAutrag.BeginUpdate();
                cmd = new OleDbCommand($"select * from Auftrag, Preisliste, FirmenKontakt, Kunden where PAuftrID=AuftragsID and KKundID=KundID and KontaktID=AuftrKontaktID and KundFName='{lBoxCompany.Text}' and KKInfo='{cBoxKont.Text}'", con);
                dr = cmd.ExecuteReader();
                cBoxAutrag.Update();
                cBoxAutrag.Items.Clear();
                while (dr.Read())
                {
                    cBoxAutrag.Update();
                    cBoxAutrag.Items.Add(dr["AuftragsID".ToString()]);
                }
                cBoxAutrag.SelectedIndex = 0;
                cBoxAutrag.EndUpdate();
            }
            catch
            {
            }

            cmd = new OleDbCommand($"select * from Auftrag, Produkt, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBoxAutrag.Text} and PProID=ProID and ProName='{cBoxProd.Text}'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            nUDMenge.Value = Convert.ToDecimal(dr["Menge"].ToString());
            lblPreis.Text = Convert.ToDecimal(dr["PreisProStk"].ToString()).ToString();
            
            
            try
            {
                cBoxSchritt.BeginUpdate();
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}'", con);
                dr = cmd.ExecuteReader();
                cBoxSchritt.Update();
                cBoxSchritt.Items.Clear();
                while (dr.Read())
                {
                    cBoxSchritt.Update();
                    cBoxSchritt.Items.Add(dr["SchrittID".ToString()]);
                }
                cBoxSchritt.SelectedIndex = 0;
                cBoxSchritt.EndUpdate();
                
                lBoxRoh.BeginUpdate();
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb, Rohstoffe where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}' and SchrittID={cBoxSchritt.Text} and SRohVID=RohID", con);
                dr = cmd.ExecuteReader();
                lBoxRoh.Update();
                lBoxRoh.Items.Clear();
                while (dr.Read())
                {
                    lBoxRoh.Update();
                    lBoxRoh.Items.Add(dr["RohName".ToString()]);
                }
                lBoxRoh.SelectedIndex = 0;
                lBoxRoh.EndUpdate();
                
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb, Rohstoffe where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}' and SchrittID={cBoxSchritt.Text} and SRohVID=RohID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                txtVerb.Text = dr["VerbMenge"].ToString();
                txtVerbGes.Text = (Convert.ToDecimal(txtVerb.Text) * nUDMenge.Value).ToString();
            }
            catch
            {
            }
        }


        private void cBAutrag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxProd.BeginUpdate();
                cmd = new OleDbCommand($"select * from Auftrag, Produkt, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBoxAutrag.Text} and PProID=ProID", con);
                dr = cmd.ExecuteReader();
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                while (dr.Read())
                {
                    cBoxProd.Update();
                    cBoxProd.Items.Add(dr["ProName".ToString()]);
                }
                cBoxProd.SelectedIndex = 0;
                cBoxProd.EndUpdate();
                
                nUDMenge.Value = Convert.ToDecimal(dr["Menge"].ToString());
                lblPreis.Text = Convert.ToDecimal(dr["PreisProStk"].ToString()).ToString();

                dTPCreated.Value = Convert.ToDateTime(dr["AuftragsDat"]);
            }
            catch
            {
            }

            Auftrag = Convert.ToInt32(cBoxAutrag.Text);
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

                groupInfo.Visible = true;
            
                nUDMenge.Visible = true;
                lblMenge.Visible = true;
                lblPreis.Visible = true;
            
                btnRohVerw.Visible = true;
                btnProdVerw.Visible = true;
            
                btnExit.Text = "Exit";
            }
        }

        private void cBoxProdukt_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand($"select * from Auftrag, Produkt, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBoxAutrag.Text} and PProID=ProID and ProName='{cBoxProd.Text}'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            try
            {
                nUDMenge.Value = Convert.ToDecimal(dr["Menge"].ToString());
                lblPreis.Text = Convert.ToDecimal(dr["PreisProStk"]).ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void lBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxKont.BeginUpdate();
                cmd = new OleDbCommand($"select * from FirmenKontakt, kunden where KundFName='{lBoxCompany.Text}' and KKundID=KundID", con);
                dr = cmd.ExecuteReader();
                cBoxKont.Update();
                cBoxKont.Items.Clear();
                while (dr.Read())
                {
                    cBoxKont.Update();
                    cBoxKont.Items.Add(dr["KKInfo".ToString()]);
                }
                cBoxKont.SelectedIndex = 0;
                cBoxKont.EndUpdate();
            }
            catch
            {
            }
        }

        private void cBoxKont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxAutrag.BeginUpdate();
                cmd = new OleDbCommand($"select * from Auftrag, FirmenKontakt, Kunden where Preisliste.PAuftrID=AuftragsID and KKundID=KundID and KontaktID=AuftrKontaktID and KundFName='{lBoxCompany.Text}' and KKInfo='{cBoxKont.Text}'", con);
                dr = cmd.ExecuteReader();
                cBoxAutrag.Update();
                cBoxAutrag.Items.Clear();
                while (dr.Read())
                {
                    cBoxAutrag.Update();
                    cBoxAutrag.Items.Add(dr["AuftragsID".ToString()]);
                }
                cBoxAutrag.SelectedIndex = 0;
                cBoxAutrag.EndUpdate();
            }
            catch
            {
            }

            try
            {
                cBoxProd.BeginUpdate();
                cmd = new OleDbCommand($"select * from Auftrag, Produkt, Preisliste, FirmenKontakt, Kunden where PAuftrID=AuftragsID and AuftragsID={cBoxAutrag.Text} and KundID=KKundID and AuftrKontaktID=KontaktID and KundFName='{lBoxCompany.Text}'", con);
                dr = cmd.ExecuteReader();
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                while (dr.Read())
                {
                    cBoxProd.Update();
                    cBoxProd.Items.Add(dr["ProName".ToString()]);
                }
                cBoxProd.SelectedIndex = 0;
                cBoxProd.EndUpdate();
                
                cmd = new OleDbCommand($"select * from Auftrag, Produkt, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBoxAutrag.Text} and PProID=ProID and ProName='{cBoxProd.Text}'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                nUDMenge.Value = Convert.ToDecimal(dr["Menge"].ToString());
                lblPreis.Text = Convert.ToDecimal(dr["PreisProStk"].ToString()).ToString();
            }
            catch
            {
            }
            
            try
            {
                cBoxSchritt.BeginUpdate();
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}'", con);
                dr = cmd.ExecuteReader();
                cBoxSchritt.Update();
                cBoxSchritt.Items.Clear();
                while (dr.Read())
                {
                    cBoxSchritt.Update();
                    cBoxSchritt.Items.Add(dr["SchrittID".ToString()]);
                }
                cBoxSchritt.SelectedIndex = 0;
                cBoxSchritt.EndUpdate();
                
                lBoxRoh.BeginUpdate();
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb, Rohstoffe where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}' and SchrittID={cBoxSchritt.Text} and SRohVID=RohID", con);
                dr = cmd.ExecuteReader();
                lBoxRoh.Update();
                lBoxRoh.Items.Clear();
                while (dr.Read())
                {
                    lBoxRoh.Update();
                    lBoxRoh.Items.Add(dr["RohName".ToString()]);
                }
                lBoxRoh.SelectedIndex = 0;
                lBoxRoh.EndUpdate();
                
                cmd = new OleDbCommand($"select * from Produkt, ProduktSchritte, SchrittRohVerb, Rohstoffe where SchrittID=SchrittRVID and ProName='{cBoxProd.Text}' and SchrittID={cBoxSchritt.Text} and SRohVID=RohID", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                txtVerb.Text = dr["VerbMenge"].ToString();
                txtVerbGes.Text = (Convert.ToDecimal(txtVerb.Text) * nUDMenge.Value).ToString();
            }
            catch
            {
            }
        }

        private void btnAuftrNeu_Click(object sender, EventArgs e)
        {
            AuftragserstellungsTool AuftrErst = new AuftragserstellungsTool();
            AuftrErst.ShowDialog(this);
            create = true;
        }

        public DateTimePicker dTPCreated = new DateTimePicker();
        public string[] Items;
        private void btnChange_Click(object sender, EventArgs e)
        {
            login log = new login();
            AuftragserstellungsTool AeT = new AuftragserstellungsTool();
            AeT.AuftragserstellungsTool_Load(this, new EventArgs());
            edit = true;

            cmd = new OleDbCommand($"Select * from Preisliste, Produkt, Auftrag where ProID=PProID and AuftragsID=PAuftrID and PAuftrID={cBoxAutrag.Text}", con);
            dr = cmd.ExecuteReader();
            AeT.cBoxProd.Items.Clear();
            while (dr.Read())
            { 
                AeT.cBoxProd.Items.Add(dr["ProName"].ToString());
                AeT.cLBoxProd.Items.Add(dr["ProName"].ToString());
                AeT.cLBoxProd.SelectedItems.Add(dr["ProName"].ToString());
            }
            AeT.btnConfirm_Click(this, new EventArgs());
            AeT.AuftrID = Convert.ToInt32(cBoxAutrag.Text);
            AeT.cBoxProd.SelectedIndex = 0;
            AeT.ShowDialog();
            AeT.lBoxCompany.Enabled = true;
            AeT.btnConfirm.Enabled = false;
        }

        private void btnAuftrBuchen_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AuftragsVerwalt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AuftragserstellungsTool AeT = new AuftragserstellungsTool();
            delete = true;
        }
    }
}
