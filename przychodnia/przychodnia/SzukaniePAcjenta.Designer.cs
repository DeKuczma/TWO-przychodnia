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
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.przychodniaDataSet1 = new przychodnia.PrzychodniaDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textPESEL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // przychodniaDataSet1
            // 
            this.przychodniaDataSet1.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(441, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(209, 71);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(86, 13);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textNazwisko.TabIndex = 4;
            // 
            // textPESEL
            // 
            this.textPESEL.Location = new System.Drawing.Point(86, 52);
            this.textPESEL.Name = "textPESEL";
            this.textPESEL.Size = new System.Drawing.Size(100, 20);
            this.textPESEL.TabIndex = 5;
            // 
            // SzukaniePacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.textPESEL);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelNazwisko);
            this.Name = "SzukaniePacjenta";
            this.Text = "Szukanie pacjenta";
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelPESEL;
        private PrzychodniaDataSet przychodniaDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textPESEL;
    }
}