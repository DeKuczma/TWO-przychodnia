namespace przychodnia
{
    partial class EdycjaPacjenta
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozytywnaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pacjenciDeklaracjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deklaracjeTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacjentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLekarzaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodICDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjenciWizytyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizytyTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.WizytyTableAdapter();
            this.butttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciWizytyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // imionaDataGridViewTextBoxColumn
            // 
            this.imionaDataGridViewTextBoxColumn.DataPropertyName = "Imiona";
            this.imionaDataGridViewTextBoxColumn.HeaderText = "Imiona";
            this.imionaDataGridViewTextBoxColumn.Name = "imionaDataGridViewTextBoxColumn";
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            // 
            // ubezpieczenieDataGridViewTextBoxColumn
            // 
            this.ubezpieczenieDataGridViewTextBoxColumn.DataPropertyName = "Ubezpieczenie";
            this.ubezpieczenieDataGridViewTextBoxColumn.HeaderText = "Ubezpieczenie";
            this.ubezpieczenieDataGridViewTextBoxColumn.Name = "ubezpieczenieDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // nrDomuDataGridViewTextBoxColumn
            // 
            this.nrDomuDataGridViewTextBoxColumn.DataPropertyName = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.HeaderText = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.Name = "nrDomuDataGridViewTextBoxColumn";
            // 
            // nrMieszkaniaDataGridViewTextBoxColumn
            // 
            this.nrMieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.HeaderText = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.Name = "nrMieszkaniaDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.idPacjentaDataGridViewTextBoxColumn,
            this.idLekarzaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.pozytywnaDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.pacjenciDeklaracjeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 251);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(732, 137);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // idPacjentaDataGridViewTextBoxColumn
            // 
            this.idPacjentaDataGridViewTextBoxColumn.DataPropertyName = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn.HeaderText = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn.Name = "idPacjentaDataGridViewTextBoxColumn";
            // 
            // idLekarzaDataGridViewTextBoxColumn
            // 
            this.idLekarzaDataGridViewTextBoxColumn.DataPropertyName = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn.HeaderText = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn.Name = "idLekarzaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // pozytywnaDataGridViewCheckBoxColumn
            // 
            this.pozytywnaDataGridViewCheckBoxColumn.DataPropertyName = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.HeaderText = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.Name = "pozytywnaDataGridViewCheckBoxColumn";
            // 
            // pacjenciDeklaracjeBindingSource
            // 
            this.pacjenciDeklaracjeBindingSource.DataMember = "PacjenciDeklaracje";
            this.pacjenciDeklaracjeBindingSource.DataSource = this.pacjenciBindingSource;
            // 
            // deklaracjeTableAdapter
            // 
            this.deklaracjeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.dataDataGridViewTextBoxColumn1,
            this.idPacjentaDataGridViewTextBoxColumn1,
            this.idLekarzaDataGridViewTextBoxColumn1,
            this.kodICDDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.pacjenciWizytyBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 394);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(733, 162);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // idPacjentaDataGridViewTextBoxColumn1
            // 
            this.idPacjentaDataGridViewTextBoxColumn1.DataPropertyName = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn1.HeaderText = "IdPacjenta";
            this.idPacjentaDataGridViewTextBoxColumn1.Name = "idPacjentaDataGridViewTextBoxColumn1";
            // 
            // idLekarzaDataGridViewTextBoxColumn1
            // 
            this.idLekarzaDataGridViewTextBoxColumn1.DataPropertyName = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn1.HeaderText = "IdLekarza";
            this.idLekarzaDataGridViewTextBoxColumn1.Name = "idLekarzaDataGridViewTextBoxColumn1";
            // 
            // kodICDDataGridViewTextBoxColumn
            // 
            this.kodICDDataGridViewTextBoxColumn.DataPropertyName = "KodICD";
            this.kodICDDataGridViewTextBoxColumn.HeaderText = "KodICD";
            this.kodICDDataGridViewTextBoxColumn.Name = "kodICDDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // pacjenciWizytyBindingSource
            // 
            this.pacjenciWizytyBindingSource.DataMember = "PacjenciWizyty";
            this.pacjenciWizytyBindingSource.DataSource = this.pacjenciBindingSource;
            // 
            // wizytyTableAdapter
            // 
            this.wizytyTableAdapter.ClearBeforeFill = true;
            // 
            // butttonAccept
            // 
            this.butttonAccept.Location = new System.Drawing.Point(12, 563);
            this.butttonAccept.Name = "butttonAccept";
            this.butttonAccept.Size = new System.Drawing.Size(361, 40);
            this.butttonAccept.TabIndex = 3;
            this.butttonAccept.Text = "Wprowadź zmiany";
            this.butttonAccept.UseVisualStyleBackColor = true;
            this.butttonAccept.Click += new System.EventHandler(this.butttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(379, 563);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(366, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EdycjaPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 615);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.butttonAccept);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EdycjaPacjenta";
            this.Text = "Edycja pacjenta";
            this.Load += new System.EventHandler(this.EdycjaPacjenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciWizytyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pacjenciDeklaracjeBindingSource;
        private PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter deklaracjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pozytywnaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource pacjenciWizytyBindingSource;
        private PrzychodniaDataSetTableAdapters.WizytyTableAdapter wizytyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodICDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}