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
    public partial class SzukaniePacjenta : Form
    {
        public SzukaniePacjenta()
        {
            InitializeComponent();
        }

        private void SzukaniePacjenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet.Deklaracje' table. You can move, or remove it, as needed.
            this.deklaracjeTableAdapter.Fill(this.przychodniaDataSet.Deklaracje);
            // TODO: This line of code loads data into the 'przychodniaDataSet.Pacjenci' table. You can move, or remove it, as needed.
            this.dataGridView1.Hide();
            this.dataGridView2.Hide();
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.przychodniaDataSet.Pacjenci);
            DataView viewDeklaracje = new DataView(this.przychodniaDataSet.Deklaracje);
            dv.RowFilter = "Nazwisko = '" + textNazwisko.Text + "' AND PESEL = '" + textPESEL.Text + "'";
            if (dv.Count != 0)
            {
                viewDeklaracje.RowFilter = "IDPacjenta = '" + dv[0][0] + "'";
                viewDeklaracje.Sort = "Data DESC";

                while (viewDeklaracje.Count > 1)
                    viewDeklaracje.Delete(1);
            }

            dataGridView1.DataSource = dv;
            dataGridView2.DataSource = viewDeklaracje;
            this.dataGridView1.Show();
            this.dataGridView2.Show();
        }
    }
}
