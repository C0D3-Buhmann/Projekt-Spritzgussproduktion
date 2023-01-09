using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace MoritzBibliothek
{
    public partial class Mitarbeiter : UserControl
    {
        
        public bool contains;
        public OleDbConnection con = new OleDbConnection();
        public OleDbDataReader dr;
        public OleDbCommand cmd;
        public int CountIDX, idx, KontaktID, MitarbeiterID, StatusID, AuftragsID, ProID, AuftrID;
        public static int checkMode;
        public Mitarbeiter()
        {
            InitializeComponent();
        }

        private void Mitarbeiter_Load(object sender, EventArgs e)
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
        }
    }
}