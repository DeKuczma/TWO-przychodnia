using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

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
            StringBuilder sb = new StringBuilder();
            sb.Append("<Deklaracje>\n");
            pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            deklaracjeTableAdapter.Fill(this.przychodniaDataSet.Deklaracje);
            lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);
            foreach(DataRow row in this.przychodniaDataSet.Pacjenci.Rows)
            {
                if (GoodDeclaration((int)row[this.przychodniaDataSet.Pacjenci.IDColumn.ColumnName], out int IDLekarza, out string declarationData))
                {
                    sb.Append("\t<Deklaracja>\n\t\t<Pacjent>\n\t\t\t<Nazwisko>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.NazwiskoColumn.ColumnName]);
                    sb.Append("</Nazwisko>\n\t\t\t<Imiona>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.ImionaColumn.ColumnName]);
                    sb.Append("</Imiona>\n\t\t\t<PESEL>");
                    sb.Append(row[przychodniaDataSet.Pacjenci.PESELColumn.ColumnName]);
                    sb.Append("</PESEL>\n\t\t\t<DataUrodzenia>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.DataUrodzeniaColumn.ColumnName]);
                    sb.Append("</DataUrodzenia>\n\t\t\t<Ubezpieczenie>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.UbezpieczenieColumn.ColumnName]);
                    sb.Append("</Ubezpieczenie>\n\t\t\t<Adres>\n\t\t\t\t<Ulica>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.UlicaColumn.ColumnName]);
                    sb.Append("</Ulica>\n\t\t\t\t<NrDomu>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.NrDomuColumn.ColumnName]);
                    sb.Append("</NrDomu>\n\t\t\t\t<NrMieszkania>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.NrMieszkaniaColumn.ColumnName]);
                    sb.Append("</NrMieszkania>\n\t\t\t\t<Miasto>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.MiastoColumn.ColumnName]);
                    sb.Append("</Miasto>\n\t\t\t\t<Kod>");
                    sb.Append(row[this.przychodniaDataSet.Pacjenci.KodColumn.ColumnName]);
                    sb.Append("</Kod>\n\t\t\t</Adres>\n\t\t</Pacjent>\n\t\t<Personel>\n");
                    GetDoctorData(ref sb, IDLekarza, declarationData);
                    sb.Append("\t\t</Personel>\n\t</Deklaracja>");
                }
            }
            sb.Append("</Deklaracje>");
            string path = "Raport.xml";
            //File.WriteAllText(path, sb.ToString());
            ZipFile(path, "Raport.zip", sb.ToString());
        }

        private bool GoodDeclaration(int IDPacient, out int IDLekarza, out string declarationData)
        {
            DataView dv = new DataView(this.przychodniaDataSet.Deklaracje);
            dv.RowFilter = this.przychodniaDataSet.Deklaracje.IdPacjentaColumn.ColumnName + "=" + IDPacient;
            dv.Sort = this.przychodniaDataSet.Deklaracje.DataColumn.ColumnName + " DESC";
            if (dv.Count == 0)
            { 
                IDLekarza = 0;
                declarationData = "";
                return false;
            }
            IDLekarza = (int)dv[0][this.przychodniaDataSet.Deklaracje.IdLekarzaColumn.ColumnName];
            declarationData = ((DateTime)dv[0][this.przychodniaDataSet.Deklaracje.DataColumn.ColumnName]).ToShortDateString();
            return (bool)dv[0][this.przychodniaDataSet.Deklaracje.PozytywnaColumn.ColumnName];
        }

        private void GetDoctorData(ref StringBuilder sb, int IDLekarza, string declarationData)
        {
            DataView dv = new DataView(this.przychodniaDataSet.Lekarze);
            dv.RowFilter = this.przychodniaDataSet.Lekarze.IDColumn.ColumnName + "=" + IDLekarza;
            sb.Append("\t\t\t<NPWZ>");
            sb.Append(dv[0][this.przychodniaDataSet.Lekarze.NPWZColumn.ColumnName]);
            sb.Append("</NPWZ>\n\t\t\t<Data>");
            sb.Append(declarationData);
            sb.Append("</Data>\n");
        }

        private void ZipFile(string inputPath, string outputPath, string outputString)
        {
            using (FileStream fileOut = File.Create(outputPath))
            {
                using (ZipOutputStream zipOut = new ZipOutputStream(fileOut))
                {
                    zipOut.SetLevel(3);
                    ZipEntry zipEntry = new ZipEntry("Raport.xml");
                    zipEntry.DateTime = DateTime.UtcNow;
                    zipOut.PutNextEntry(zipEntry);

                    byte[] buffer = Encoding.UTF8.GetBytes(outputString);
                    zipOut.Write(buffer, 0, buffer.Length);

                    zipOut.IsStreamOwner = false;
                    zipOut.Close();
                }
            }
        }
    }
}
