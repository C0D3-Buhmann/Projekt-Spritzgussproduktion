using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using static Projekt_Spritzgussproduktion.Configure;

namespace Projekt_Spritzgussproduktion
{
    public class Rechteverwaltung
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public Configure Conf = new Configure();
        
        public Abteilung Abt;
        public Position Pos;
        public Prozess Proz;
        public Rechte Recht;
        public Mitarbeiter Mitarb;
        login log = new login();
        
        List<Rechte> Rechte
        {
            get { return Rechte; }
            set { _Rechte = value; }
        }
        private List<Rechte> _Rechte;
        public int OctaDecID 
        {
            get { return OctaDecID; }
            set { _OctaDecID = value; }
        }
        private int _OctaDecID;
        
        public int AbteilungsID 
        {
            get { return AbteilungsID; }
            set { _AbteilungsID = value; }
        }
        private int _AbteilungsID;
        public int MitarbID 
        {
            get { return MitarbID; }
            set { _MitarbID = value; }
        }
        private int _MitarbID;
        
        public int PositionsID 
        {
            get { return PositionsID; }
            set { _PositionsID = value; }
        }
        private int _PositionsID;
        
        public int ProzessID 
        {
            get { return ProzessID; }
            set { _ProzessID = value; }
        }
        private int _ProzessID;
        public string AktuellerProzessName 
        {
            get { return AktuellerProzessName; }
            set { _AktuellerProzessName = value; }
        }
        private string _AktuellerProzessName;

        public bool AccessPermission 
        {
            get { return AccessPermission; }
            set { _AccessPermission = value; }
        }
        private bool _AccessPermission;

        public Rechteverwaltung()
        {
            
        }
        public Rechteverwaltung(int IDp, int IDa, int IDOcta, int IDm, bool AP) : this()
        {
            Rechteverwaltung_Load(this, new EventArgs());
            _OctaDecID = IDp;
            _AbteilungsID = IDa;
            _ProzessID = IDOcta;
            _MitarbID = IDm;
            _AccessPermission = AP;
        }
        
        private void Rechteverwaltung_Load(object sender, EventArgs e)
        {
            string ConString;
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
            
            _Rechte = new List<Rechte>();
            Check(0, Mitarb.MitarbAbt);
            Check(1, Mitarb.MitarbPos);
            Check(2, Mitarb.MitarbID);
        }

        

        private void Check(int Arg, int CheckedID)
        {
            switch (Arg)
            {
                case 0:
                    if (Mitarb.MitarbAbt == Proz.ProzessAbt)
                    {
                        _AbteilungsID = Proz.ProzessAbt;
                    }
                    break;
                case 1:
                    if (Mitarb.MitarbPos == Proz.ProzessPos)
                    {
                        _PositionsID = Proz.ProzessPos;
                    }
                    break;
                case 2:
                    if (Mitarb.MitarbID == Proz.ProzessMitarbID)
                    {
                        _MitarbID = Proz.ProzessMitarbID;
                    }
                    break;
            }
            switch (Arg)
            {
                case 0:
                    if (Mitarb.MitarbAbt == CheckedID)
                    {
                        _AbteilungsID = Proz.ProzessAbt;
                    }
                    break;
                case 1:
                    if (Mitarb.MitarbPos == CheckedID)
                    {
                        _PositionsID = Proz.ProzessPos;
                    }
                    break;
                case 2:
                    if (Mitarb.MitarbID == CheckedID)
                    {
                        _MitarbID = Proz.ProzessMitarbID;
                    }
                    break;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Rechteverwaltung objAsRechteverwaltung = obj as Rechteverwaltung;
            if (objAsRechteverwaltung == null) return false;
            else return Equals(objAsRechteverwaltung);
        }

        public override int GetHashCode()
        {
            return MitarbID;
        }

        public bool Equals(Mitarbeiter other)
        {
            if (other == null) return false;
            return (this.MitarbID.Equals(other.MitarbID));
        }
    }
}