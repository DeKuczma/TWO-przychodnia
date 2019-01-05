namespace przychodnia
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLekarze = new System.Windows.Forms.Button();
            this.buttonPacjent = new System.Windows.Forms.Button();
            this.buttonWizyty = new System.Windows.Forms.Button();
            this.buttonSerchPacjent = new System.Windows.Forms.Button();
            this.buttonRaport = new System.Windows.Forms.Button();
            this.przychodniaDataSet = new przychodnia.PrzychodniaDataSet();
            this.pacjenciTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.PacjenciTableAdapter();
            this.wizytyTableAdapter = new przychodnia.PrzychodniaDataSetTableAdapters.WizytyTableAdapter();
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacjenciDeklaracjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLekarze
            // 
            this.buttonLekarze.Location = new System.Drawing.Point(13, 13);
            this.buttonLekarze.Name = "buttonLekarze";
            this.buttonLekarze.Size = new System.Drawing.Size(270, 23);
            this.buttonLekarze.TabIndex = 0;
            this.buttonLekarze.Text = "Edytuj dane lekarzy";
            this.buttonLekarze.UseVisualStyleBackColor = true;
            this.buttonLekarze.Click += new System.EventHandler(this.buttonLekarze_Click);
            // 
            // buttonPacjent
            // 
            this.buttonPacjent.Location = new System.Drawing.Point(13, 43);
            this.buttonPacjent.Name = "buttonPacjent";
            this.buttonPacjent.Size = new System.Drawing.Size(270, 23);
            this.buttonPacjent.TabIndex = 1;
            this.buttonPacjent.Text = "Edytuj pacjentów";
            this.buttonPacjent.UseVisualStyleBackColor = true;
            this.buttonPacjent.Click += new System.EventHandler(this.buttonPacjent_Click);
            // 
            // buttonWizyty
            // 
            this.buttonWizyty.Location = new System.Drawing.Point(13, 73);
            this.buttonWizyty.Name = "buttonWizyty";
            this.buttonWizyty.Size = new System.Drawing.Size(270, 23);
            this.buttonWizyty.TabIndex = 2;
            this.buttonWizyty.Text = "Edytuj wizyty";
            this.buttonWizyty.UseVisualStyleBackColor = true;
            this.buttonWizyty.Click += new System.EventHandler(this.buttonWizyty_Click);
            // 
            // buttonSerchPacjent
            // 
            this.buttonSerchPacjent.Location = new System.Drawing.Point(13, 103);
            this.buttonSerchPacjent.Name = "buttonSerchPacjent";
            this.buttonSerchPacjent.Size = new System.Drawing.Size(270, 23);
            this.buttonSerchPacjent.TabIndex = 3;
            this.buttonSerchPacjent.Text = "Szukaj pacjenta";
            this.buttonSerchPacjent.UseVisualStyleBackColor = true;
            this.buttonSerchPacjent.Click += new System.EventHandler(this.buttonSerchPacjent_Click);
            // 
            // buttonRaport
            // 
            this.buttonRaport.Location = new System.Drawing.Point(13, 133);
            this.buttonRaport.Name = "buttonRaport";
            this.buttonRaport.Size = new System.Drawing.Size(270, 23);
            this.buttonRaport.TabIndex = 4;
            this.buttonRaport.Text = "Generuj raport";
            this.buttonRaport.UseVisualStyleBackColor = true;
            this.buttonRaport.Click += new System.EventHandler(this.buttonRaport_Click);
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
            // wizytyTableAdapter
            // 
            this.wizytyTableAdapter.ClearBeforeFill = true;
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "Pacjenci";
            this.pacjenciBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // pacjenciDeklaracjeBindingSource
            // 
            this.pacjenciDeklaracjeBindingSource.DataMember = "PacjenciDeklaracje";
            this.pacjenciDeklaracjeBindingSource.DataSource = this.pacjenciBindingSource;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(295, 171);
            this.Controls.Add(this.buttonRaport);
            this.Controls.Add(this.buttonSerchPacjent);
            this.Controls.Add(this.buttonWizyty);
            this.Controls.Add(this.buttonPacjent);
            this.Controls.Add(this.buttonLekarze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przychodnia";
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciDeklaracjeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLekarze;
        private System.Windows.Forms.Button buttonPacjent;
        private System.Windows.Forms.Button buttonWizyty;
        private System.Windows.Forms.Button buttonSerchPacjent;
        private System.Windows.Forms.Button buttonRaport;
        private PrzychodniaDataSet przychodniaDataSet;
        private PrzychodniaDataSetTableAdapters.PacjenciTableAdapter pacjenciTableAdapter;
        private PrzychodniaDataSetTableAdapters.WizytyTableAdapter wizytyTableAdapter;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private System.Windows.Forms.BindingSource pacjenciDeklaracjeBindingSource;
    }
}

