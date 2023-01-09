using System;
using System.Data;
using System.Data.OleDb;
using static Projekt_Spritzgussproduktion.AuftragsVerwalt;

namespace Projekt_Spritzgussproduktion
{
    public class IDVerwalt
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        AuftragsVerwalt AV = new AuftragsVerwalt();
        
        public void AuftragsID()
        {
            var PAuftrID = AV.cBAutrag.Text;
            cmd = new OleDbCommand($"select * from  Auftrag, Preisliste where PAuftrID={Convert.ToInt32(PAuftrID)}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
                
            AV.nUDMenge.Value = Convert.ToDecimal(dr["Menge".ToString()]);
        }
    }
}