namespace przychodnia
{
    partial class EdycjaWizyty
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
            this.wizytyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new przychodnia.PrzychodniaDataSet();
            this.wizytyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizytyTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.WizytyTableAdapter();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCDTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.ICDTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodICDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idPacjentaDataGridViewTextBoxColumn,
            this.idLekarzaDataGridViewTextBoxColumn,
            this.kodICDDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wizytyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // wizytyBindingSource1
            // 
            this.wizytyBindingSource1.DataMember = "Wizyty";
            this.wizytyBindingSource1.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wizytyBindingSource
            // 
            this.wizytyBindingSource.DataMember = "Wizyty";
            this.wizytyBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // wizytyTableAdapter
            // 
            this.wizytyTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(13, 415);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(646, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Wprowadź zmiany";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
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
            // kodICDDataGridViewTextBoxColumn
            // 
            this.kodICDDataGridViewTextBoxColumn.DataPropertyName = "KodICD";
            this.kodICDDataGridViewTextBoxColumn.DataSource = this.iCDBindingSource;
            this.kodICDDataGridViewTextBoxColumn.DisplayMember = "Nazwa";
            this.kodICDDataGridViewTextBoxColumn.HeaderText = "KodICD";
            this.kodICDDataGridViewTextBoxColumn.Name = "kodICDDataGridViewTextBoxColumn";
            this.kodICDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodICDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kodICDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // EdycjaWizyty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EdycjaWizyty";
            this.Text = "Edycja wizyty";
            this.Load += new System.EventHandler(this.EdycjaWizyty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource wizytyBindingSource;
        private PrzychodniaDataSetTableAdapters.WizytyTableAdapter wizytyTableAdapter;
        private System.Windows.Forms.BindingSource wizytyBindingSource1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PrzychodniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodICDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}