using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia
{
    public partial class EdycjaLekarzy : Form
    {

        public EdycjaLekarzy()
        {
            InitializeComponent();
        }

        private void EdycjaLekarzy_Load(object sender, EventArgs e)
        {
            this.lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int ret = this.lekarzeTableAdapter.Update(this.przychodniaDataSet.Lekarze);
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
