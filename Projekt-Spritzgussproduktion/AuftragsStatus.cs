﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public partial class AuftragsStatus : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public AuftragsStatus()
        {
            InitializeComponent();
        }

        private void AuftragsStatus_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from SchrittRohVerb", con);
            ds.Clear();
            DataAdapt.Fill(ds, "SchrittRohVerb");
            dGView.DataSource = ds;
            dGView.DataMember = "SchrittRohVerb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from ProduktSchritte", con);
            ds.Clear();
            DataAdapt.Fill(ds, "ProduktSchritte");
            dGView.DataSource = ds;
            dGView.DataMember = "ProduktSchritte";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Preisliste", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Kunden");
            dGView.DataSource = ds;
            dGView.DataMember = "Kunden";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Produkt", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Produkt");
            dGView.DataSource = ds;
            dGView.DataMember = "Produkt";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Rohstoffe", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Rohstoffe");
            dGView.DataSource = ds;
            dGView.DataMember = "Rohstoffe";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Auftrag", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Auftrag");
            dGView.DataSource = ds;
            dGView.DataMember = "Auftrag";
        }

        private void test1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Kunden", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Kunden");
            dGView.DataSource = ds;
            dGView.DataMember = "Kunden";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from FirmenKontakt", con);
            ds.Clear();
            DataAdapt.Fill(ds, "FirmenKontakt");
            dGView.DataSource = ds;
            dGView.DataMember = "FirmenKontakt";
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Kunden, FirmenKontakt where KundID=KKundID", con);
            ds.Clear();
            DataAdapt.Fill(ds, "FirmenKontakt&Kunden");
            dGView.DataSource = ds;
            dGView.DataMember = "FirmenKontakt&Kunden";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Mitarbeiter", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Mitarbeiter");
            dGView.DataSource = ds;
            dGView.DataMember = "Mitarbeiter";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Mitarbeiter, MitAbteilung, MitPosID", con);
            ds.Clear();
            DataAdapt.Fill(ds, "MitarbeiterAP");
            dGView.DataSource = ds;
            dGView.DataMember = "MitarbeiterAP";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from MitAbteilung", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Abteilung");
            dGView.DataSource = ds;
            dGView.DataMember = "Abteilung";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from MitPosID", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Position");
            dGView.DataSource = ds;
            dGView.DataMember = "Position";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataAdapt = new OleDbDataAdapter($"Select * from RohstoffVerbrauch", con);
            ds.Clear();
            DataAdapt.Fill(ds, "RohstoffVerbrauch");
            dGView.DataSource = ds;
            dGView.DataMember = "RohstoffVerbrauch";
        }
        
    }
}