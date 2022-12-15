using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LukasBibliothek.KundVerwalt;

namespace Projekt_Spritzgussproduktion
{
    static class Program
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbDataReader dr;
        private static OleDbCommand cmd;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=ProjektX.accdb";
            con.Open();
            cmd = new OleDbCommand("update set SchrittRohVerb SRohVID = 2 where RSchrittID=2", con);*/
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login());
            //Application.Run(new AuftragsVerwalt());
            //Application.Run(new AuftragserstellungsTool());
            //Application.Run(new AuftragsStatus());
            //Application.Run(new HomeMenu());
            Application.Run(new MoritzBibliothek.UserVerwalt());
        }
    }
}