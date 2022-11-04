using System;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnUserVerw_Click(object sender, EventArgs e)
        {
            MoritzBibliothek.UserVerwalt uV = new MoritzBibliothek.UserVerwalt();
            uV.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}