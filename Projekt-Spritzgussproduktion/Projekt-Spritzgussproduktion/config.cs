using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Projekt_Spritzgussproduktion
{
    public static class configuration
    {
        static DataSet ds = new DataSet();
        public static OleDbDataAdapter DataAdapt;
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbDataReader dr;
        private static OleDbCommand cmd;
        public static void configScript()
        {
            try
            {
                try
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Projekt.accdb";
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Projekt.accdb";
                    con.Open();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                throw;
            }

            /*switch ()
            {
                
            }*/
        }
    }
}