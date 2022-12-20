using System;
using System.CodeDom;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static Projekt_Spritzgussproduktion.Configure;

namespace Projekt_Spritzgussproduktion
{
    public partial class AuftragsVerwalt : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private string ConString;
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private bool create, edit, delete, finished;
        private int id = 0;
        public AuftragsVerwalt()
        {
            InitializeComponent();
        }

        private void AuftragsVerwalt_Load(object sender, EventArgs e)
        {
            ProzesseFenster.tagDeclaration(null, 1);
            try
            {
                ConString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=ProjektX.accdb";
                try
                {
                    con.ConnectionString = ConString;
                }
                catch
                {
                    ConString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjektX.accdb";
                    con.ConnectionString = ConString;
                }
                ConCheck(con ,ConString);
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

            if (cBoxKontakt.Text != "" && cBoxMitarb.Text != "" && cBoxProd.Text != "" && cBoxStatus.Text != "" &&
                nUDMengeN.Value <= 0 && nUDPreisN.Value <= 0)
            {
                btnAccept.Enabled = true;
            }
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
                con.Close();
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
                cBAutrag.Enabled = true;
            
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
            btnExit.Text = "Abbruch";
            groupAuftrVerwalt.Visible = true;
            groupInfo.Visible = false;
            btnDelete.Visible = false;
            btnChange.Visible = false;
            btnAuftrNeu.Enabled = false;
            nUDMenge.Visible = false;
            lblMenge.Visible = false;
            lblPreis.Visible = false;
            cBAutrag.Enabled = false;
            cBoxStatus.Enabled = false;

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
            btnExit.Text = "Abbruch";
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
            
            /*cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBAutrag.Text}", con);
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
            }*/

            try
            {
                cmd = new OleDbCommand(
                    $"select * from FirmenKontakt, Auftrag, Kunden where AuftragsID={cBAutrag.Text} and AuftrKontaktID=KontaktID and KundID=KKundID",
                    con);
                dr = cmd.ExecuteReader();
                dr.Read();
                var ActCompany = dr["KKInfo"].ToString();

                cmd = new OleDbCommand($"select * from Kunden", con);
                dr = cmd.ExecuteReader();
                cBoxKontakt.Update();
                cBoxKontakt.Text = "";
                cBoxKontakt.Items.Clear();
                while (dr.Read())
                {
                    cBoxKontakt.Items.Add(dr["KKInfo"].ToString());
                }

                cBoxKontakt.SelectedText = ActCompany;
                cBoxKontakt.EndUpdate();
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
                clBProd.Update();
                clBProd.Items.Clear();
                while (dr.Read())
                {
                    clBProd.Items.Add(dr["ProName"].ToString());
                }
                clBProd.EndUpdate();
                var c = clBProd.Items.ToString().ToString();
                
                /*cBoxProd.Update();
                cBoxProd.Text = "";
                cBoxProd.Items.Clear();
                foreach (var a in c)
                {
                    cBoxProd.Items.Add(a);
                }
                cBoxProd.EndUpdate();*/
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
            cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID=AuftragsID and AuftragsID={cBAutrag.Text}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            lblPreis.Text = (Convert.ToDecimal(dr["PreisProStk"]) * nUDMenge.Value).ToString();
        }

        private void nUDMengeN_ValueChanged(object sender, EventArgs e)
        {
            lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
            btnSavePM.Enabled = true;
        }

        private void nUDPreisN_ValueChanged(object sender, EventArgs e)
        {
            lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
            btnSavePM.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnAuftrBuchen.Enabled = true;
            groupAuftrVerwalt.Enabled = false;
            finished = true;
            btnExit.Text = "Abbruch";
        }

        private void btnAuftrBuchen_Click(object sender, EventArgs e)
        {
            
            
                
            if (create)
            {
                try
                {
                    foreach (string a in clBProd.Items)
                    {
                        insertDB();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
                cBoxStatus.Enabled = true;
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
            
            
            btnAuftrBuchen.Enabled = true;
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
            cBAutrag.Enabled = true;
            finished = false;
        }

        private void AuftragsVerwalt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && finished)
            {
                btnAuftrBuchen_Click(this, new EventArgs());
            }
        }

        /*private void clBProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                foreach (var i in clBProd.CheckedItems)
                {
                    cBoxProd.Items.Add(i.ToString());
                }
                cBoxProd.SelectedIndex = 0;
                cBoxProd.EndUpdate();
            }
            catch
            {
            } 
        }*/
        
        private void cBoxProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand(
                    $"select * from Produkt where ProName='{cBoxProd.Text}'",
                    con);
                dr = cmd.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["ProID"].ToString());
            }
            catch
            {
                
            }
            pupd();
        }

        /*private void clBProd_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                foreach (var i in clBProd.CheckedItems)
                {
                    cBoxProd.Items.Add(i.ToString());
                }
                cBoxProd.SelectedIndex = 0;
                cBoxProd.EndUpdate();
            }
            catch
            {
            }
        }*/

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            nUDMengeN.Enabled = true;
            nUDPreisN.Enabled = true;
            cBoxProd.Enabled = true;
            btnEdit.Enabled = true;
            clBProd.Enabled = false;
            btnConfirm.Enabled = false;
            
            try
            {
                cmd = new OleDbCommand(
                    $"select * from Produkt where ProName='{cBoxProd.Text}'",
                    con);
                dr = cmd.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["ProID"].ToString());
            }
            catch
            {
                
            }
            
            try
            {
                cBoxProd.Update();
                cBoxProd.Items.Clear();
                foreach (var i in clBProd.CheckedItems)
                {
                    cBoxProd.Items.Add(i.ToString());
                }
                cBoxProd.SelectedIndex = 0;
                cBoxProd.EndUpdate();
            }
            catch
            {
            }
            pupd();
        }

        private void pupd()
        {
            cmd = new OleDbCommand($"select Menge, ProdPreisStk from  Auftrag, Preisliste, Produkt where (ProID={id} and PProID=ProID) or ProID={id}", con);            
            dr = cmd.ExecuteReader();
            dr.Read();
            
            try
            {
                nUDMengeN.Update();
                nUDMengeN.Value = Convert.ToDecimal(dr["Menge"].ToString());
            }
            catch
            {
            }

            try
            {
                nUDPreisN.Update();
                nUDPreisN.Value = Convert.ToDecimal(dr["ProdPreisStk"].ToString());
            }
            catch
            {
                
            }
            lblNewPreisXMenge.Text = (Convert.ToDecimal(nUDPreisN.Value) * Convert.ToDecimal(nUDMengeN.Value)).ToString();
        }

        private void cBoxKontakt_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand($"select * from  Kunden, FirmenKontakt where KundID=KKundID and KKundID={cBoxKontakt.Text}", con);            
            dr = cmd.ExecuteReader();
            cBoxCompany.Update();
            cBoxCompany.Items.Clear();
            while (dr.Read())
            {
                cBoxCompany.Items.Add(dr["KundFName"].ToString());
            }
            cBoxCompany.SelectedIndex = 0;
            cBoxCompany.EndUpdate();
            
            cmd = new OleDbCommand($"select * from FirmenKontakt where KontaktID={cBoxKontakt.Text}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            txtEmail.Text = dr["KontaktEmail"].ToString();
            txtInfo.Text = dr["KKInfo"].ToString();
            txtTel.Text = dr["KontaktTel"].ToString();
            txtFax.Text = dr["KontaktFTel"].ToString();
            txtLocation.Text = dr["KontaktRechnAdr"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            nUDMengeN.Enabled = false;
            nUDPreisN.Enabled = false;
            cBoxProd.Enabled = false;
            btnEdit.Enabled = false;
            clBProd.Enabled = true;
            btnConfirm.Enabled = true;
        }

        private void btnSavePM_Click(object sender, EventArgs e)
        {
            if (create)
            {
                
            }
            else if (edit)
            {
                
            }
        }

        private void insertDB()
        {
            int Mitarbeiter, Status, ProID, CountProID, CountAuftrID;
            decimal PreisValue = 0, menge = 0;
            
            try
            {
                /*cmd = new OleDbCommand($"Select MitUUID from Mitarbeiter where MitName='{cBoxMitarb.Text}'", con);
                cmd.ExecuteReader();
                dr.Read();*/
                Mitarbeiter = cBoxMitarb.SelectedIndex;
                Mitarbeiter++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            try
            {
                /*cmd = new OleDbCommand($"Select * from Status where Statusmeldung='{cBoxStatus.Text}'", con);
                cmd.ExecuteReader();
                dr.Read();*/
                Status = cBoxStatus.SelectedIndex;
                Status++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            try
            {
                /*cmd = new OleDbCommand($"select * from Preisliste, Produkt where ProName='{cBoxProd.Text}' and ProID=PProID", con);
                cmd.ExecuteReader();
                dr.Read();*/
                ProID = cBoxProd.SelectedIndex;
                ProID++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            
           
            try //insert Auftrag
            {
                Mitarbeiter = cBoxMitarb.SelectedIndex;
                Status = cBoxStatus.SelectedIndex;
                cmd = new OleDbCommand("select * from Produkt where ProID=(select max(ProID) from Produkt)", con);
                ProID = cBoxProd.SelectedIndex;
                Mitarbeiter++;
                Status++;
                ProID++;
                CountAuftrID = 0;
                menge = 0;
                    
                cmd = new OleDbCommand($"insert into Auftrag (AuftragsDat, AuftrZMitID, Auftragsstatus, AuftrKontaktID) values ('{DateTime.Now}', {Mitarbeiter}, 2, {cBoxKontakt.Text})", con);
                cmd.ExecuteNonQuery();
                dr.Read();


                MessageBox.Show(cBoxProd.Items.Count.ToString());
                for (var a = 0; a >= cBoxProd.Items.Count; a++)
                {
                    try
                    {
                        MessageBox.Show(a.ToString());
                        cBoxProd.SelectedIndex = a;
                        cmd = new OleDbCommand(
                            $"select * from Produkt, Preisliste where ProName='{cBoxProd.Text}' and PProID=ProID", con);
                        cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ProID = Convert.ToInt32(dr["ProID"].ToString());
                        }

                        foreach (int at in cBAutrag.Items)
                        {
                            var tmp = 0;
                            if (tmp < at)
                            {
                                tmp = at;
                                CountAuftrID = at;
                            }
                        }


                        cmd = new OleDbCommand(
                            $"select Menge, ProdPreisStk from  Auftrag, Preisliste, Produkt where (ProID={ProID} and PProID=ProID) or ProID={ProID}",
                            con);
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        try
                        {
                            menge = Convert.ToDecimal(dr["Menge"].ToString());
                        }
                        catch
                        {
                        }

                        try
                        {
                            PreisValue = Convert.ToDecimal(dr["ProdPreisStk"].ToString());
                        }
                        catch
                        {
                        }

                        MessageBox.Show(
                            ("ID: " + CountAuftrID + "\n" +
                             "Mitarbeiter: " + Mitarbeiter + "\n" +
                             "Status: " + Status + "\n" +
                             "ProID: " + ProID + "\n" +
                             "PreisValue: " + PreisValue + "\n" +
                             "Menge: " + menge + "\n").ToString()
                        );
                        cmd = new OleDbCommand(
                            $"insert into Preisliste (PProID, PAuftrID, PreisProStk, PreisInklMenge, Menge) values ({ProID}, {CountAuftrID}, '{PreisValue}', '{PreisValue * menge}', {menge})",
                            con);
                        cmd.ExecuteNonQuery();
                        dr.Read();
                        btnSavePM.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show(a.ToString());
                        cBoxProd.SelectedIndex = a;
                        cmd = new OleDbCommand(
                            $"select * from Produkt, Preisliste where ProName='{cBoxProd.Text}' and PProID=ProID", con);
                        cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ProID = Convert.ToInt32(dr["ProID"].ToString());
                        }

                        foreach (int at in cBAutrag.Items)
                        {
                            var tmp = 0;
                            if (tmp < at)
                            {
                                tmp = at;
                                CountAuftrID = at;
                            }
                        }


                        cmd = new OleDbCommand(
                            $"select Menge, ProdPreisStk from  Auftrag, Preisliste, Produkt where (ProID={ProID} and PProID=ProID) or ProID={ProID}",
                            con);
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        try
                        {
                            menge = Convert.ToDecimal(dr["Menge"].ToString());
                        }
                        catch
                        {
                        }

                        try
                        {
                            PreisValue = Convert.ToDecimal(dr["ProdPreisStk"].ToString());
                        }
                        catch
                        {
                        }

                        MessageBox.Show(
                            ("ID: " + CountAuftrID + "\n" +
                             "Mitarbeiter: " + Mitarbeiter + "\n" +
                             "Status: " + Status + "\n" +
                             "ProID: " + ProID + "\n" +
                             "PreisValue: " + PreisValue + "\n" +
                             "Menge: " + menge + "\n").ToString()
                        );
                        cmd = new OleDbCommand(
                            $"insert into Preisliste (PProID, PAuftrID, PreisProStk, PreisInklMenge, Menge) values ({ProID}, {CountAuftrID}, '{PreisValue}', '{PreisValue * menge}', {menge})",
                            con);
                        cmd.ExecuteNonQuery();
                        dr.Read();
                        btnSavePM.Enabled = false;
                    }
                }
            }
            catch 
            {
            }
            
            try //insert Preisliste
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        private void txtReload_Click(object sender, EventArgs e)
        {
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

            if (cBoxKontakt.Text != "" && cBoxMitarb.Text != "" && cBoxProd.Text != "" && cBoxStatus.Text != "" &&
                nUDMengeN.Value <= 0 && nUDPreisN.Value <= 0)
            {
                btnAccept.Enabled = true;
            }
        }
    }
}