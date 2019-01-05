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
    public partial class EdycjaPacjenta : Form
    {
        private DataView deklaracjaView;
        private DataView wizytaView;

        public EdycjaPacjenta()
        {
            InitializeComponent();
        }

        private void EdycjaPacjenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet.Wizyty' table. You can move, or remove it, as needed.
            this.wizytyTableAdapter.Fill(this.przychodniaDataSet.Wizyty);
            // TODO: This line of code loads data into the 'przychodniaDataSet.Deklaracje' table. You can move, or remove it, as needed.
            this.deklaracjeTableAdapter.Fill(this.przychodniaDataSet.Deklaracje);
            // TODO: This line of code loads data into the 'przychodniaDataSet.Pacjenci' table. You can move, or remove it, as needed.
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);

            deklaracjaView = new DataView(this.przychodniaDataSet.Deklaracje);
            wizytaView = new DataView(this.przychodniaDataSet.Wizyty);
            this.dataGridView2.DataSource = deklaracjaView;
            this.dataGridView3.DataSource = wizytaView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int pacientId = (int)dataGridView1.Rows[index].Cells[0].Value;

                StringBuilder sb = new StringBuilder();
                sb.Append(this.przychodniaDataSet.Wizyty.IdPacjentaColumn);
                sb.Append(" = '");
                sb.Append(pacientId);
                sb.Append("'");
                wizytaView.RowFilter = sb.ToString();
                deklaracjaView.RowFilter = sb.ToString();
            }
        }

        private void butttonAccept_Click(object sender, EventArgs e)
        {
            pacjenciTableAdapter.Update(przychodniaDataSet.Pacjenci);
            wizytyTableAdapter.Update(przychodniaDataSet.Wizyty);
            deklaracjeTableAdapter.Update(przychodniaDataSet.Deklaracje);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
