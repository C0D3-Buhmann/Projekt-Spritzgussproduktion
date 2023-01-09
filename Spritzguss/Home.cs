using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Spritzguss
{
    public partial class Home : Form
    {
    
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private string UUID = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from *", con);
            cListBox.BeginUpdate();
            cListBox.Update();
            cListBox.Items.Clear();
            MessageBox.Show(dr.GetSchemaTable().ToString());
            for(int i=0;i<dr.FieldCount;i++)
            {
                cListBox.Update();
               cListBox.Items.Add(dr.GetName(i));
            }
    }
    }
}