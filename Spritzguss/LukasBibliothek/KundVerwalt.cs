using System;
using System.Windows.Forms;

namespace LukasBibliothek
{
    public partial class KundVerwalt : Form
    {
        public static bool Enabled { get; set; }
        public KundVerwalt()
        {
            InitializeComponent();
        }

        public void btnH_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KundVerwalt_Load(object sender, EventArgs e)
        {
            Enabled = false;
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            KundenHinzufügen KH = new KundenHinzufügen();
            KH.Show();
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            KundenKontaktAnzeige KA = new KundenKontaktAnzeige();
            KA.Show();
        }

        private void btnKKH_Click(object sender, EventArgs e)
        {
            KundenKontaktHinzufügen KKH = new KundenKontaktHinzufügen();
            KKH.Show();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            KundenAnzeige K = new KundenAnzeige();
            K.Show();
        }
    }
}