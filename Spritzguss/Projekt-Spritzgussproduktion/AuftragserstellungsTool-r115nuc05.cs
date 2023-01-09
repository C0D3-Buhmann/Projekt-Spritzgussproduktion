using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;
using static Projekt_Spritzgussproduktion.AuftragsVerwalt;

namespace Projekt_Spritzgussproduktion
{
    public partial class AuftragserstellungsTool : Form
    {

        public bool contains;
        public List<Create> newProd = new List<Create>();
        public OleDbConnection con = new OleDbConnection();
        public OleDbDataReader dr;
        public OleDbCommand cmd;
        public int CountIDX, idx, KontaktID, MitarbeiterID, StatusID, AuftragsID, ProID, AuftrID;
        public static int checkMode;

        public AuftragserstellungsTool()
        {
            InitializeComponent();
        }
        
        public void AuftragserstellungsTool_Load(object sender, EventArgs e)
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
            catch
            {
            }
            
            if (create)
            {
                checkMode = 0;
            }
            else if (edit)
            {
                checkMode = 1;
            }
            else if (view)
            {
                checkMode = 2;
            }
            else if (delete)
            {
                checkMode = 3;
            }
            
         
            switch (checkMode)
            {
                case 0:
                    cLBoxProd.Enabled = true;
                    
                    cLBoxProd.Visible = true;
                    cmd = new OleDbCommand("Select * from Produkt", con);
                    dr = cmd.ExecuteReader();
                    cLBoxProd.BeginUpdate();
                    cLBoxProd.Update();
                    cLBoxProd.Items.Clear();
                    while (dr.Read())
                    {
                        cLBoxProd.Items.Add(dr["ProName"].ToString());
                    }
                    cLBoxProd.EndUpdate();
                    cLBoxProd.Enabled = true;
                    btnConfirm.Enabled = true;
                    cBoxProd.Enabled = false;
                    
                    break;
                case 1:
                    cmd = new OleDbCommand($"Select * from Preisliste, Produkt, Auftrag where ProID=PProID and AuftragsID=PAuftrID and PAuftrID={Auftrag}", con);
                    dr = cmd.ExecuteReader();
                    cLBoxProd.BeginUpdate();
                    cLBoxProd.Update();
                    cLBoxProd.Items.Clear();
                    while (dr.Read())
                    { 
                        cBoxProd.Items.Add(dr["ProName"].ToString());
                    }
                    cLBoxProd.EndUpdate();
                   

                    cBoxProd.SelectedIndex = 0;
                    cBoxProd.EndUpdate();
                    
                    
                    
                    cmd = new OleDbCommand($"Select * from Preisliste, Produkt, Auftrag where ProID=PProID and AuftragsID=PAuftrID and PAuftrID={Auftrag}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    try
                    {

                        dTPCreated.Value = Convert.ToDateTime(dr["AuftragsDat"]);
                    }
                    catch
                    {
                    }
                    btnConfirm.Enabled = false;
                    break;
                case 2:
                    
                    break;
                case 3:
                    cLBoxProd.Items.Clear();
                    cBoxProd.Items.Clear();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }

            btnForward.Enabled = true;
            btnBackward.Enabled = true;
            btnSafe.Enabled = true;
            nUDMenge.Enabled = true;
            nUDPreis.Enabled = true;
            cBoxProd.Enabled = true;
            txtGesammt.Enabled = true;

            try
            {
                idx = Convert.ToInt32(btnWinCount.Text);
                contains = newProd.Contains(new Create() { ID = idx });
            }
            catch
            {
            }

        }

        public void btnConfirm_Click(object sender, EventArgs e)
        {
            if (create)
            {
                checkMode = 0;
            }
            else if (edit)
            {
                checkMode = 1;
            }
            else if (view)
            {
                checkMode = 2;
            }
            else if (delete)
            {
                checkMode = 3;
            }

            switch (checkMode)
            {
                case 0:
                    cmd = new OleDbCommand("Select * from Produkt", con);
                    dr = cmd.ExecuteReader();
                    cLBoxProd.BeginUpdate();
                    cLBoxProd.Update();
                    cLBoxProd.Items.Clear();
                    while (dr.Read())
                    {
                        cLBoxProd.Items.Add(dr["ProName"].ToString());
                    }

                    cLBoxProd.EndUpdate();
                    cBoxProd.Enabled = true;
                    btnSafe.Enabled = true;
                    break;
                case 1:
                    if (btnConfirm.Text == "Bestätigen")
                    {
                        try
                        {
                            cBoxProd.BeginUpdate();
                            cBoxProd.Update();
                            cBoxProd.Items.Clear();
                            cmd = new OleDbCommand($"Select * from Preisliste, Produkt, Auftrag where ProID=PProID and AuftragsID=PAuftrID and PAuftrID={Auftrag}", con);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            { 
                                cBoxProd.Items.Add(dr["ProName"].ToString());
                                cLBoxProd.Items.Add(dr["ProName"].ToString());
                            }
                            cBoxProd.SelectedIndex = 0;
                            cBoxProd.EndUpdate();
                        }
                        catch
                        {
                            
                        }

                        CountIDX = cBoxProd.Items.Count;
                        CountIDX--;

                        btnForward.Enabled = true;
                        btnBackward.Enabled = true;
                        btnSafe.Enabled = true;
                        nUDMenge.Enabled = true;
                        nUDPreis.Enabled = true;
                        cBoxProd.Enabled = true;
                        //cLBoxProd.Enabled = false;
                        txtGesammt.Enabled = true;

                        btnWinCount.Text = cBoxProd.SelectedIndex.ToString();
                        idx = Convert.ToInt32(btnWinCount.Text);
                        contains = newProd.Contains(new Create() { ID = idx });

                        btnConfirm.Text = "Zurück";
                    }
                    else if (btnConfirm.Text == "Zurück")
                    {
                        btnForward.Enabled = false;
                        btnBackward.Enabled = false;
                        btnSafe.Enabled = false;
                        nUDMenge.Enabled = false;
                        nUDPreis.Enabled = false;
                        cBoxProd.Enabled = false;
                        cLBoxProd.Enabled = true;
                        txtGesammt.Enabled = false;

                        btnConfirm.Text = "Bestätigen";
                    }

                    break;
                case 2:
                    try
                    {
                        con.Open();
                    }
                    catch
                    {
                    }
                    if (btnConfirm.Text == "Bestätigen")
                    {
                        try
                        {
                            cBoxProd.BeginUpdate();
                            cBoxProd.Update();
                            cBoxProd.Items.Clear();
                            foreach (string g in cLBoxProd.CheckedItems)
                            {
                                cBoxProd.Update();
                                cBoxProd.Items.Add(g);
                            }

                            cBoxProd.SelectedIndex = 0;
                            cBoxProd.EndUpdate();
                        }
                        catch
                        {
                        }

                        CountIDX = cBoxProd.Items.Count;
                        CountIDX--;

                        btnForward.Enabled = true;
                        btnBackward.Enabled = true;
                        btnSafe.Enabled = true;
                        nUDMenge.Enabled = true;
                        nUDPreis.Enabled = true;
                        cBoxProd.Enabled = true;
                        //cLBoxProd.Enabled = false;
                        txtGesammt.Enabled = true;

                        btnWinCount.Text = cBoxProd.SelectedIndex.ToString();
                        idx = Convert.ToInt32(btnWinCount.Text);
                        contains = newProd.Contains(new Create() { ID = idx });

                        btnConfirm.Text = "Zurück";
                    }
                    else if (btnConfirm.Text == "Zurück")
                    {
                        btnForward.Enabled = false;
                        btnBackward.Enabled = false;
                        btnSafe.Enabled = false;
                        nUDMenge.Enabled = false;
                        nUDPreis.Enabled = false;
                        cBoxProd.Enabled = false;
                        cLBoxProd.Enabled = true;
                        txtGesammt.Enabled = false;

                        btnConfirm.Text = "Bestätigen";
                    }

                    break;
                case 3:
                    cLBoxProd.Items.Clear();
                    cBoxProd.Items.Clear();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }

        private void AuftragserstellungsTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Close();
        }

        private void cBoxProd_TextChanged(object sender, EventArgs e)
        {
            loadProd();
        }

        private void cBoxProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProd();
        }

        void loadProd()
        {

            btnWinCount.Text = cBoxProd.SelectedIndex.ToString();
            try
            {
                idx = Convert.ToInt32(btnWinCount.Text);
                contains = newProd.Contains(new Create() { ID = idx });
            }
            catch
            {
            }


            if (contains)
            {
                if (newProd[idx].isSaved())
                {
                    checcheckBSaved.Checked = true;
                    nUDMenge.Value = newProd[idx].getMenge();
                    nUDPreis.Value = newProd[idx].getPreis();
                }
                else if (!newProd[idx].isSaved())
                {
                    checcheckBSaved.Checked = false;
                }
            }
            else
            {
                cmd = new OleDbCommand(
                    $"Select * from Produkt, Preisliste where ProName='{cBoxProd.Text}' and ProID=PProID", con);
                dr = cmd.ExecuteReader();
                dr.Read();

                try
                {
                    nUDMenge.Value = Convert.ToDecimal(dr["Menge"]);
                    nUDPreis.Value = Convert.ToDecimal(dr["ProdPreisStk"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                var i = 0;
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            backward();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void backward()
        {
            if (cBoxProd.SelectedIndex > 0)
            {
                cBoxProd.SelectedIndex--;
            }
            else
            {
                for (int count = 0; count <= 50; count++)
                {
                    try
                    {
                        cBoxProd.SelectedIndex = count;
                    }
                    catch
                    {
                    }
                }
            }

            try
            {
                btnWinCount.Text = cBoxProd.SelectedIndex.ToString();
                idx = Convert.ToInt32(btnWinCount.Text);
                contains = newProd.Contains(new Create() { ID = idx });
                cBoxProd.SelectedIndex = idx;
            }
            catch
            {
            }

            try
            {
                if (newProd[idx].isSaved())
                {
                    checcheckBSaved.Checked = true;
                    txtLIDX.Text = newProd[idx].outputID();
                    txtLName.Text = newProd[idx].outputName();
                    txtLMenge.Text = newProd[idx].outputMenge();
                    txtLPreis.Text = newProd[idx].outputPreis();
                    txtLGesammtPreis.Text = newProd[idx].outputGesammtpreis();
                    txtLChecked.Text = newProd[idx].outputSaved();
                }
                else
                {
                    txtLIDX.Text = "";
                    txtLName.Text = "";
                    txtLMenge.Text = "";
                    txtLPreis.Text = "";
                    txtLGesammtPreis.Text = "";
                    txtLChecked.Text = "";
                    checcheckBSaved.Checked = false;
                }
            }
            catch
            {
                txtLIDX.Text = "";
                txtLName.Text = "";
                txtLMenge.Text = "";
                txtLPreis.Text = "";
                txtLGesammtPreis.Text = "";
                txtLChecked.Text = "";
                checcheckBSaved.Checked = false;
            }
        }

        private void forward()
        {
            try
            {
                cBoxProd.SelectedIndex++;
            }
            catch (Exception exception)
            {
                cBoxProd.SelectedIndex = 0;
            }

            try
            {
                btnWinCount.Text = cBoxProd.SelectedIndex.ToString();
                idx = Convert.ToInt32(btnWinCount.Text);
                contains = newProd.Contains(new Create() { ID = idx });
                cBoxProd.SelectedIndex = idx;
            }
            catch
            {
            }

            try
            {
                if (newProd[idx].isSaved())
                {
                    checcheckBSaved.Checked = true;
                    txtLIDX.Text = newProd[idx].outputID();
                    txtLName.Text = newProd[idx].outputName();
                    txtLMenge.Text = newProd[idx].outputMenge();
                    txtLPreis.Text = newProd[idx].outputPreis();
                    txtLGesammtPreis.Text = newProd[idx].outputGesammtpreis();
                    txtLChecked.Text = newProd[idx].outputSaved();
                }
                else
                {
                    txtLIDX.Text = "";
                    txtLName.Text = "";
                    txtLMenge.Text = "";
                    txtLPreis.Text = "";
                    txtLGesammtPreis.Text = "";
                    txtLChecked.Text = "";
                    checcheckBSaved.Checked = false;
                }
            }
            catch
            {
                txtLIDX.Text = "";
                txtLName.Text = "";
                txtLMenge.Text = "";
                txtLPreis.Text = "";
                txtLGesammtPreis.Text = "";
                txtLChecked.Text = "";
                checcheckBSaved.Checked = false;
            }
        }

        private void nUDMenge_ValueChanged(object sender, EventArgs e)
        {
            txtGesammt.Text = (nUDMenge.Value * nUDPreis.Value).ToString();
        }

        private void nUDPreis_ValueChanged(object sender, EventArgs e)
        {
            txtGesammt.Text = (nUDMenge.Value * nUDPreis.Value).ToString();
        }

        public void btnSafe_Click(object sender, EventArgs e)
        {
            cBoxMitarb.Enabled = true;
            cBoxMitarb.BeginUpdate();
            cBoxMitarb.Update();
            cBoxMitarb.Items.Clear();
            switch (checkMode)
            {
                case 0:
                    cmd = new OleDbCommand("Select * from Mitarbeiter", con);
                    dr = cmd.ExecuteReader();
                    break;
                case 1:
                    cmd = new OleDbCommand($"Select * from Mitarbeiter, Auftrag", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    var Mitarbeiter = dr["MitName"].ToString();
                    
                    while (dr.Read())
                    {
                        cBoxMitarb.Update();
                        cBoxMitarb.Items.Add(dr["MitName"].ToString());
                    }

                    cBoxMitarb.SelectedText = Mitarbeiter;
                    cBoxMitarb.EndUpdate();
                    btnConfirmMitarb.Enabled = true;
                    break;
            }
            
            while (dr.Read())
            {
                cBoxMitarb.Update();
                cBoxMitarb.Items.Add(dr["MitName"].ToString());
            }

            try
            {
                cBoxMitarb.SelectedIndex = 0;
            }
            catch
            {
            }
            cBoxMitarb.EndUpdate();
            cmd = new OleDbCommand("Select * from Mitarbeiter", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            try
            {

                txtMitUUID.Text = dr["MitUUID"].ToString();
                txtMitUserName.Text = dr["MitUserName"].ToString();
                txtMitEmail.Text = dr["MitEmail"].ToString();
                txtPasswd.Text = dr["MitUserPasswd"].ToString();
                txtKundAbteilung.Text = dr["MitAbtID"].ToString();
                txtKundPosition.Text = dr["MitPosID"].ToString();
            }
            catch
            {
            }
            
            switch (btnSafe.Text)
            {
                case "Sichern":
                    if (!checcheckBSaved.Checked)
                    {
                        newProd.Add(new Create()
                        {
                            ID = idx,
                            Name = cBoxProd.Text,
                            Preis = nUDPreis.Value,
                            Menge = nUDMenge.Value,
                            Gesammtpreis = Convert.ToDecimal(txtGesammt.Text),
                            Saved = true
                        });
                        checcheckBSaved.Checked = true;
                    }
                    else if (contains)
                    {
                        if (newProd[idx].isSaved())
                        {
                            checcheckBSaved.Checked = true;
                        }
                    }
                    else if (!contains)
                    {
                        checcheckBSaved.Checked = false;
                    }

                    int check = 0;
                    foreach (var a in newProd)
                    {
                        if (a.isSaved())
                        {
                            check++;
                        }
                    }

                    

                    if (check == cBoxProd.Items.Count)
                    {
                        btnSafe.Text = "Abschließen";
                    }

                    break;
                case "Abschließen":
                    btnSafe.Enabled = false;
                    nUDMenge.Enabled = false;
                    nUDPreis.Enabled = false;
                    cBoxProd.Enabled = false;
                    cLBoxProd.Enabled = false;
                    txtGesammt.Enabled = false;
                    btnConfirm.Enabled = false;
                    btnForward.Enabled = false;
                    btnBackward.Enabled = false;
                    btnForward2.Enabled = true;
                    btnBackward2.Enabled = true;
                    btnBackward2.Enabled = true;
                    btnConfirmMitarb.Enabled = true;
                    btnMitBack.Enabled = true;
                    btnSafe.Enabled = false;
                    break;
            }
        }

        private void btnForward2_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void btnBackward2_Click(object sender, EventArgs e)
        {
            backward();
        }

        private void cBoxMitarb_TextChanged(object sender, EventArgs e)
        {

            cmd = new OleDbCommand($"Select * from Mitarbeiter where MitName='{cBoxMitarb.Text}'", con);
            dr = cmd.ExecuteReader();
            dr.Read();

            MitarbeiterID = Convert.ToInt32(dr["MitUUID"].ToString());

            var MitarbPos = Convert.ToInt32(dr["MitPosID"].ToString());
            var MitarbAbt = Convert.ToInt32(dr["MitAbtID"].ToString());

            txtMitUUID.Text = dr["MitUUID"].ToString();
            txtMitUserName.Text = dr["MitUserName"].ToString();
            
            
            

            cmd = new OleDbCommand($"Select * from Position, Mitarbeiter where MitPosID=PosID and MitPosID={MitarbPos}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            txtKundPosition.Text = dr["PosBez"].ToString();

            cmd = new OleDbCommand($"Select * from MitAbteilung where MitAbtID={MitarbAbt}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            txtKundAbteilung.Text = dr["AbtName"].ToString();
        }
        
        public void switchTelMail()
        {
            bool NeverEndingStory = false;
            do
            {
                lblTel.Text = "Email";
                txtMitEmail.Text = dr["MitEMail"].ToString();
                System.Threading.Thread.Sleep(1000);
                lblTel.Text = "Tel";
                txtMitEmail.Text = dr["MitTel"].ToString();
                System.Threading.Thread.Sleep(1000);
                lblTel.Text = "Email";
                txtMitEmail.Text = dr["MitEMail"].ToString();
            } while (NeverEndingStory);
            
        }
        private void btnConfirmMitarb_Click(object sender, EventArgs e)
        {
            cBoxMitarb.Enabled = false;
            gBoxCon.Enabled = true;
            btnMitBack.Enabled = false;

            lBoxCompany.BeginUpdate();
            lBoxCompany.Update();
            lBoxCompany.Items.Clear();
            cmd = new OleDbCommand("Select * from Kunden", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lBoxCompany.Items.Add(dr["KundFName"].ToString());
            }

            lBoxCompany.SelectedIndex = 0;
            lBoxCompany.EndUpdate();
        }

        private void btnKundBack_Click(object sender, EventArgs e)
        {
            cBoxMitarb.Enabled = true;
            gBoxCon.Enabled = false;
        }

        private void lBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxKontakt.BeginUpdate();
            cBoxKontakt.Update();
            cBoxKontakt.Items.Clear();
            cmd = new OleDbCommand(
                $"Select * from Kunden, FirmenKontakt where KundID=KKundID and KundFName='{lBoxCompany.Text}'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cBoxKontakt.Items.Add(dr["KKInfo"].ToString());
            }

            cBoxKontakt.SelectedIndex = 0;
            cBoxKontakt.EndUpdate();


            dr.Read();


        }

        private void cBoxKontakt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand(
                $"Select * from Kunden, FirmenKontakt where KundID=KKundID and KundFName='{lBoxCompany.Text}' and KKInfo='{cBoxKontakt.Text}'",
                con);
            dr = cmd.ExecuteReader();
            dr.Read();
            KontaktID = Convert.ToInt32(dr["KontaktID"].ToString());

            txtKundEmail.Text = dr["KontaktEmail"].ToString();
            txtKundTel.Text = dr["KontaktTel"].ToString();
            txtKundFax.Text = dr["KontaktFTel"].ToString();
            txtKundLocation.Text = dr["KontaktRechnAdr"].ToString();
            txtKundID.Text = dr["KKundID"].ToString();
            txtKontaktID.Text = dr["KontaktID"].ToString();
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            switch (checkMode)
            {
                case 0:
                    gBoxCon.Enabled = false;
                    btnBuchen.Enabled = true;
                    btnLastBack.Enabled = true;
                    break;
                case 1:
                    if (dTPCreated.Enabled)
                    {
                        dTPCreated.Visible = false;
                        cBoxStatus.Enabled = false;
                    }
                    else if (cBoxStatus.Enabled)
                    {
                        gBoxCon.Enabled = false;
                        btnBuchen.Enabled = true;
                        btnLastBack.Enabled = true;
                        lblStatus.Text = "Auftragsdatum";
                    }
                    break;
                default: 
                    
                    break;
            }
            
        }

        private void btnLastBack_Click(object sender, EventArgs e)
        {
            btnLastBack.Enabled = false;
            gBoxCon.Enabled = true;
            btnBuchen.Enabled = false;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            AuftragsStatus AS = new AuftragsStatus();
            AS.Show();
        }

        private void btnMitBack_Click(object sender, EventArgs e)
        {
            btnMitBack.Enabled = false;
            btnBuchen.Enabled = false;

            btnForward.Enabled = true;
            btnBackward.Enabled = true;
            btnSafe.Enabled = true;
            nUDMenge.Enabled = true;
            nUDPreis.Enabled = true;
            cBoxProd.Enabled = true;
            cLBoxProd.Enabled = false;
            txtGesammt.Enabled = true;
        }

        private int x = 1;

        public void Edit(int[] ProID, string sql)
        {
            cmd = new OleDbCommand(
                $"Select * from Preisliste, Produkt, Auftrag where ProID=PProID and AuftragsID=PAuftrID and PAuftrID={AuftrID}",
                con);
            dr = cmd.ExecuteReader();
            foreach (var x in dr)
            {
                cBoxProd.Items.Add(dr["ProName"].ToString());
                cLBoxProd.Items.Add(dr["ProName"].ToString());
                cLBoxProd.SelectedItems.Add(dr["ProName"].ToString());
            }

            while (dr.Read())
            {
            }

            btnConfirm_Click(this, new EventArgs());
            ShowDialog();
            lBoxCompany.Enabled = true;
        }


        private void btnBuchen_Click(object sender, EventArgs e)
        {
            switch (checkMode)
            {
                case 0:
                    StatusID = 2;
                    cmd = new OleDbCommand(
                        $"insert into Auftrag (AuftragsDat, AuftrZMitID, AuftrKontaktID, Auftragsstatus) values ('{DateTime.Now}', {MitarbeiterID}, {KontaktID}, {StatusID})",
                        con);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand(
                        $"select AuftragsID from Auftrag where AuftragsID=(select max(AuftragsID) from Auftrag)", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    AuftragsID = Convert.ToInt32(dr["AuftragsID"].ToString());

                    foreach (var a in newProd)
                    {
                        cmd = new OleDbCommand($"Select * from Produkt where ProName='{a.outputName()}'", con);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        ProID = Convert.ToInt32(dr["ProID"].ToString());

                        MessageBox.Show(
                            $"{ProID}, {AuftragsID}, '{a.getPreis()}', '{a.getPreis() * a.getMenge()}', '{a.getMenge()}'");

                        cmd = new OleDbCommand(
                            $"insert into Preisliste (PProID, PAuftrID, PreisProStk, PreisInklMenge, Menge) values ({ProID}, {AuftragsID}, '{a.getPreis()}', '{a.getPreis() * a.getMenge()}', '{a.getMenge()}')",
                            con);
                        cmd.ExecuteReader();
                    }

                    break;
                case 1:
                    StatusID = 2;
                    cmd = new OleDbCommand(
                        $"insert into Auftrag (AuftragsDat, AuftrZMitID, AuftrKontaktID, Auftragsstatus) values ('{DateTime.Now}', {MitarbeiterID}, {KontaktID}, {StatusID})",
                        con);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand(
                        $"select AuftragsID from Auftrag where AuftragsID=(select max(AuftragsID) from Auftrag)", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    AuftragsID = Convert.ToInt32(dr["AuftragsID"].ToString());

                    foreach (var a in newProd)
                    {
                        cmd = new OleDbCommand($"Select * from Produkt where ProName='{a.outputName()}'", con);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        ProID = Convert.ToInt32(dr["ProID"].ToString());

                        MessageBox.Show(
                            $"{ProID}, {AuftragsID}, '{a.getPreis()}', '{a.getPreis() * a.getMenge()}', '{a.getMenge()}'");

                        cmd = new OleDbCommand(
                            $"insert into Preisliste (PProID, PAuftrID, PreisProStk, PreisInklMenge, Menge) values ({ProID}, {AuftragsID}, '{a.getPreis()}', '{a.getPreis() * a.getMenge()}', '{a.getMenge()}')",
                            con);
                        cmd.ExecuteReader();
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }

        }

        private void cBoxMitarb_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txtMitTel_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void test1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dTPCreated_ValueChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
