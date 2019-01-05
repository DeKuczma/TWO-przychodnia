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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPacjent_Click(object sender, EventArgs e)
        {
            EdycjaPacjenta edycja = new EdycjaPacjenta();
            edycja.ShowDialog();
        }

        private void buttonLekarze_Click(object sender, EventArgs e)
        {
            EdycjaLekarzy edycja = new EdycjaLekarzy();
            edycja.ShowDialog();
        }

        private void buttonWizyty_Click(object sender, EventArgs e)
        {
            EdycjaWizyty edycja = new EdycjaWizyty();
            edycja.ShowDialog();
        }

        private void buttonSerchPacjent_Click(object sender, EventArgs e)
        {
            SzukaniePacjenta szukanie = new SzukaniePacjenta();
            szukanie.ShowDialog();
        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
