namespace przychodnia
{
    partial class SzukaniePacjenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textPESEL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imionaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubezpieczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrMieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new przychodnia.PrzychodniaDataSet();
            this.pacjenciTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.PacjenciTableAdapter();
            this.deklaracjeTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozytywnaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pacjenciDeklaracjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(12, 13);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(56, 13);
            this.labelNazwisko.TabIndex = 0;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(13, 52);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(44, 13);
            this.labelPESEL.TabIndex = 1;
            this.labelPESEL.Text = "PESEL:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(292, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(209, 60);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(86, 13);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(200, 20);
            this.textNazwisko.TabIndex = 4;
            // 
            // textPESEL
            // 
            this.textPESEL.Location = new System.Drawing.Point(86, 52);
            this.textPESEL.Name = "textPESEL";
            this.textPESEL.Size = new System.Drawing.Size(200, 20);
            this.textPESEL.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imionaDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.ubezpieczenieDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrDomuDataGridViewTextBoxColumn,
            this.nrMieszkaniaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacjenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(637, 107);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imionaDataGridViewTextBoxColumn
            // 
            this.imionaDataGridViewTextBoxColumn.DataPropertyName = "Imiona";
            this.imionaDataGridViewTextBoxColumn.HeaderText = "Imiona";
            this.imionaDataGridViewTextBoxColumn.Name = "imionaDataGridViewTextBoxColumn";
            this.imionaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubezpieczenieDataGridViewTextBoxColumn
            // 
            this.ubezpieczenieDataGridViewTextBoxColumn.DataPropertyName = "Ubezpieczenie";
            this.ubezpieczenieDataGridViewTextBoxColumn.HeaderText = "Ubezpieczenie";
            this.ubezpieczenieDataGridViewTextBoxColumn.Name = "ubezpieczenieDataGridViewTextBoxColumn";
            this.ubezpieczenieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrDomuDataGridViewTextBoxColumn
            // 
            this.nrDomuDataGridViewTextBoxColumn.DataPropertyName = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.HeaderText = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.Name = "nrDomuDataGridViewTextBoxColumn";
            this.nrDomuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrMieszkaniaDataGridViewTextBoxColumn
            // 
            this.nrMieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.HeaderText = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.Name = "nrMieszkaniaDataGridViewTextBoxColumn";
            this.nrMieszkaniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            this.miastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "Pacjenci";
            this.pacjenciBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacjenciTableAdapter
            // 
            this.pacjenciTableAdapter.ClearBeforeFill = true;
            // 
            // deklaracjeTableAdapter
            // 
            this.deklaracjeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.idPacjentaDataGridViewTextBoxColumn,
            this.idLekarzaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.pozytywnaDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.pacjenciDeklaracjeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 93);
            this.dataGridView2.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idPacjentaDataGridViewTextBoxColumn
            // 
            this.idPacjentaDataGridViewTextBoxColumn.DataPropertyName = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn.HeaderText = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn.Name = "idPacjentaDataGridViewTextBoxColumn";
            this.idPacjentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLekarzaDataGridViewTextBoxColumn
            // 
            this.idLekarzaDataGridViewTextBoxColumn.DataPropertyName = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn.HeaderText = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn.Name = "idLekarzaDataGridViewTextBoxColumn";
            this.idLekarzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pozytywnaDataGridViewCheckBoxColumn
            // 
            this.pozytywnaDataGridViewCheckBoxColumn.DataPropertyName = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.HeaderText = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.Name = "pozytywnaDataGridViewCheckBoxColumn";
            this.pozytywnaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pacjenciDeklaracjeBindingSource
            // 
            this.pacjenciDeklaracjeBindingSource.DataMember = "PacjenciDeklaracje";
            this.pacjenciDeklaracjeBindingSource.DataSource = this.pacjenciBindingSource;
            // 
            // SzukaniePacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 314);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textPESEL);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelNazwisko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SzukaniePacjenta";
            this.Text = "Szukanie pacjenta";
            this.Load += new System.EventHandler(this.SzukaniePacjenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textPESEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private PrzychodniaDataSetTableAdapters.PacjenciTableAdapter pacjenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubezpieczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrMieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter deklaracjeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pozytywnaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource pacjenciDeklaracjeBindingSource;
    }
}