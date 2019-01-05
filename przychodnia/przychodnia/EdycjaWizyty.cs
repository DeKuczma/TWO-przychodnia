using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia
{
    public partial class EdycjaWizyty : Form
    {
        public EdycjaWizyty()
        {
            InitializeComponent();
        }

        private void EdycjaWizyty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet.ICD' table. You can move, or remove it, as needed.
            this.iCDTableAdapter.Fill(this.przychodniaDataSet.ICD);
            // TODO: This line of code loads data into the 'przychodniaDataSet.Wizyty' table. You can move, or remove it, as needed.
            this.wizytyTableAdapter.Fill(this.przychodniaDataSet.Wizyty);

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.wizytyTableAdapter.Update(this.przychodniaDataSet.Wizyty);
            this.Close();
        }
    }
}
