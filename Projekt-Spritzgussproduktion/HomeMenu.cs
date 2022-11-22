using System;
using System.Data.OleDb;
using System.Windows.Forms;
using LukasBibliothek;
using MoritzBibliothek;

namespace Projekt_Spritzgussproduktion
{
    public partial class HomeMenu : Form
    {
        
        private OleDbConnection con = new OleDbConnection();
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void btnMitVerw_Click(object sender, EventArgs e)
        {
            try
            {
                MitarbVerw MV = new MitarbVerw();
                MV.ShowDialog();
            }
            catch
            {
            }
        }

        private void btnUserVerw_Click(object sender, EventArgs e)
        {
            UserVerwalt UV = new UserVerwalt();
            UV.ShowDialog();
        }

        private void btnAuftrVerw_Click(object sender, EventArgs e)
        {
            try {
                AuftragsVerwalt AV = new AuftragsVerwalt();
                AV.ShowDialog();
            }
            catch
            {
            }
        }

        private void btnProdVerw_Click(object sender, EventArgs e)
        {
            ProdVerwalt PV = new ProdVerwalt();
            PV.ShowDialog();
        }

        private void btnRohVerw_Click(object sender, EventArgs e)
        {
            RohVerwalt RV = new RohVerwalt();
            RV.ShowDialog();
        }

        private void btnRechnVerw_Click(object sender, EventArgs e)
        {
            RechnVerwalt RV = new RechnVerwalt();
            RV.ShowDialog();
        }

        private void btnAmin_Click(object sender, EventArgs e)
        {
            admintools AT = new admintools();
            AT.ShowDialog();
        }

        private void btnAuftragsstatus_Click(object sender, EventArgs e)
        {
            AuftragsStatus AS = new AuftragsStatus();
            AS.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            con.Close();
        }

        private void btnLieferscheine_Click(object sender, EventArgs e)
        {
            Lieferschein LS = new Lieferschein();
            LS.ShowDialog();
        }

        private void btnKunVerw_Click(object sender, EventArgs e)
        {
            KundVerwalt KV = new KundVerwalt();
            KV.ShowDialog();
        }
    }
}