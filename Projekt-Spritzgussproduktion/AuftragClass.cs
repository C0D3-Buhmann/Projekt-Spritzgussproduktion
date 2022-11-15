using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public class AuftragC : IEquatable<AuftragC>
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public int id { get; set; }
        public int AuftragID { get; set; }
        public DateTime AuftrDate { get; set; }
        public DateTime EditDate { get; set; }
        public string PAuftragID { get; set; }
        public int ProduktID { get; set; }
        public int[] PProduktID { get; set; }
        public int[] SchrittID { get; set; }
        public int[] RschrittVID { get; set; }
        public string LagID { get; set; }
        public int[] RohID { get; set; }
        public int AuftrMenge { get; set; }
        public string ProdPreis { get; set; }
        public string ProdStkPReisEur { get; set; }
        public int StatusID { get; set; }
        public int KontaktID { get; set; }
        public int KundID { get; set; }
        public int MitrarbeiterID { get; set; }

        public bool NewAuftr { get; set; }
        public bool EditAuftr { get; set; }
        public bool DelAufr { get; set; }
        public bool CheckAuftr { get; set; }
        public Form1 login = new Form1();

        AuftragC()
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
            }
            int AID = 1;
            var AuftragsDaten = new List<AuftragC>()
            {
                new AuftragC { AuftragID = setAuftragID(), AuftrDate = DateTime.Now, EditDate = DateTime.Now, MitrarbeiterID=setMitrarbeiterID(), KontaktID=setKontaktID(), StatusID=setStatusID()}
            };
        }
        public override string ToString()
        {
            string answ = "";
            if (CheckAuftr)
            {
                answ = $"ID: {AuftragID}\n Auftragsstatus: {ProduktID}\n " +
                       $"Auftrag erstellt am: {AuftrDate}\n" +
                       $"Kontakt:  {KontaktID} im auftrag von: {KundID}\n " +
                       $"zuständiger Mitarbeiter: {MitrarbeiterID}\n\n " +
                       $"Produkt: {ProduktID}" +
                       $"Stückpreis: {ProdStkPReisEur}\n" +
                       $"Bestellmenge: {AuftrMenge}\n" +
                       $"PreisInsg: {ProdStkPReisEur}\n" +
                       $"Lager: {LagID}\n"; /* +
                   $": {}\n" +
                   $": {}\n" + */
            }
            else if (NewAuftr)
            {
                answ = $"ID: {AuftragID}\n" +
                       $"Datum heute: {AuftrDate}\n" +
                       $"Kontakt:  {KontaktID} im auftrag von: {KundID}\n " +
                       $"zuständiger Mitarbeiter: {login.userID}\n\n " +
                       $"Produkt: {ProduktID}" +
                       $"Stückpreis: {ProdStkPReisEur}\n" +
                       $"Bestellmenge: {AuftrMenge}\n" +
                       $"PreisInsg: {ProdStkPReisEur}\n" +
                       $"Lager: {LagID}\n";
            }
            else if (EditAuftr)
            {
                answ = $"ID: {AuftragID}\n" +
                       $"Erstelldatum: {AuftrDate}\n" +
                       $"Bearbeitungsdatum: {EditAuftr}\n" +
                       $"Kontakt:  {KontaktID} im auftrag von: {KundID}\n " +
                       $"zuständiger Mitarbeiter: {login.userID}\n\n " +
                       $"Produkt: {ProduktID}" +
                       $"Stückpreis: {ProdStkPReisEur}\n" +
                       $"Bestellmenge: {AuftrMenge}\n" +
                       $"PreisInsg: {ProdStkPReisEur}\n" +
                       $"Lager: {LagID}\n";
            }
            else
            {
                answ = $"ID: {AuftragID}\n" +
                       $"Datum: {AuftrDate}\n" +
                       $"Kontakt:  {KontaktID} im auftrag von: {KundID}\n " +
                       $"zuständiger Mitarbeiter: {login.userID}\n\n " +
                       $"Produkt: {ProduktID}" +
                       $"Stückpreis: {ProdStkPReisEur}\n" +
                       $"Bestellmenge: {AuftrMenge}\n" +
                       $"PreisInsg: {ProdStkPReisEur}\n" +
                       $"Lager: {LagID}\n";
            }

            return answ;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            AuftragC obAsAuftragC = obj as AuftragC;
            if (obAsAuftragC == null) return false;
            else return Equals(obAsAuftragC);
        }

        public override int GetHashCode()
        {
            return AuftragID;
        }

        public bool Equals(AuftragC other)
        {
            if (other == null) return false;
            return (this.AuftragID.Equals(other.AuftragID));
        }

        public int setAuftragID()
        {
            cmd = new OleDbCommand($"select * from Auftrag where AuftagsID={id}", con);
            cmd.ExecuteReader();
            foreach (var a in dr["AuftagsID"].ToString())
            {
                id = Convert.ToInt32(dr["AuftagsID"].ToString());
            }
            return id;
        }
        public int setStatusID()
        {
            cmd = new OleDbCommand("select Auftragsstatus from Auftrag where AuftagsID={id}", con);
            cmd.ExecuteReader();
            foreach (var a in dr["Auftragsstatus"].ToString())
            {
                id = Convert.ToInt32(dr["Auftragsstatus"].ToString());
            }
            return id;
        }
        public int setMitrarbeiterID()
        {
            cmd = new OleDbCommand($"select AuftrZMitID from Auftrag where AuftagsID={id}", con);
            cmd.ExecuteReader();
            foreach (var a in dr["ProID"].ToString())
            {
                id = Convert.ToInt32(dr["ProID"].ToString());
            }
            return id;
        }
        public int setKontaktID()
        {
            cmd = new OleDbCommand("select AuftrKontaktID from Auftrag where AuftagsID={id}", con);
            cmd.ExecuteReader();
            foreach (var a in dr["AuftrKontaktID"].ToString())
            {
                id = Convert.ToInt32(dr["AuftrKontaktID"].ToString());
            }
            return id;
        }
        public int setOther()
        {
            cmd = new OleDbCommand("select * from Auftrag, Preisliste where AuftagsID={id} and AuftagsID=PAuftrID", con);
            cmd.ExecuteReader();
            foreach (var a in dr["Auftragsstatus"].ToString())
            {
                id = Convert.ToInt32(dr["Auftragsstatus"].ToString());
            }
            return id;
        }
}

    public class AuftragCon
    {
       
    }
}