using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static Projekt_Spritzgussproduktion.Configure;

namespace Projekt_Spritzgussproduktion
{
    public class Configure : IEquatable<Configure>
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        public Mitarbeiter Mitarb = new Mitarbeiter();
        public int ID
        {
            get { return ID; }
            set { _ID = value; }
        }
        private int _ID;

        public string Content
        {
            get { return Content; }
            set { _Content = value; }
        }
        private string _Content;
        
        public List<Prozess> ConfigureProzess()
        {
            List<Prozess> Configure = new List<Prozess>();
            return Configure;
        }
        
        public override string ToString()
        {
            return "ID: " + ID + " Content: " + Content;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Configure objAsConfigure = obj as Configure;
            if (objAsConfigure == null) return false;
            else return Equals(objAsConfigure);
        }
        public override int GetHashCode()
        {
            return ID;
        }

        public bool Equals(Configure other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
        
        public static void ConCheck( OleDbConnection conCheck, string conString )
        {
            conCheck = new OleDbConnection();
            if (conCheck.State == ConnectionState.Closed)
            {
                conCheck.ConnectionString = conString;
                conCheck.Open();
            }
        }
    }
}