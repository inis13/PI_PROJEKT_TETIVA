namespace Projekt_PI_Tetiva
{
    partial class frmOtpremnice
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
            this.btnKreiranjeOtpremnice = new System.Windows.Forms.Button();
            this.btnBrisanjeOtpremnice = new System.Windows.Forms.Button();
            this.btnPregledOtpremnice = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.otpremniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpremniceDataSet = new Projekt_PI_Tetiva.OtpremniceDataSet();
            this.otpremniceTableAdapter = new Projekt_PI_Tetiva.OtpremniceDataSetTableAdapters.OtpremniceTableAdapter();
            this.otpremniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOtpremnice = new System.Windows.Forms.DataGridView();
            this.otpremniceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.otpremniceeDataSet = new Projekt_PI_Tetiva.otpremniceeDataSet();
            this.otpremniceTableAdapter1 = new Projekt_PI_Tetiva.otpremniceeDataSetTableAdapters.OtpremniceTableAdapter();
            
            this.joinedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtpremnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceeDataSet)).BeginInit();
           
            this.SuspendLayout();
            // 
            // btnKreiranjeOtpremnice
            // 
            this.btnKreiranjeOtpremnice.Location = new System.Drawing.Point(22, 107);
            this.btnKreiranjeOtpremnice.Name = "btnKreiranjeOtpremnice";
            this.btnKreiranjeOtpremnice.Size = new System.Drawing.Size(92, 41);
            this.btnKreiranjeOtpremnice.TabIndex = 0;
            this.btnKreiranjeOtpremnice.Text = "Kreiranje otpremnice";
            this.btnKreiranjeOtpremnice.UseVisualStyleBackColor = true;
            this.btnKreiranjeOtpremnice.Click += new System.EventHandler(this.btnKreiranjeOtpremnice_Click);
            // 
            // btnBrisanjeOtpremnice
            // 
            this.btnBrisanjeOtpremnice.Location = new System.Drawing.Point(22, 154);
            this.btnBrisanjeOtpremnice.Name = "btnBrisanjeOtpremnice";
            this.btnBrisanjeOtpremnice.Size = new System.Drawing.Size(92, 41);
            this.btnBrisanjeOtpremnice.TabIndex = 1;
            this.btnBrisanjeOtpremnice.Text = "Brisanje otpremnice";
            this.btnBrisanjeOtpremnice.UseVisualStyleBackColor = true;
            this.btnBrisanjeOtpremnice.Click += new System.EventHandler(this.btnBrisanjeOtpremnice_Click);
            // 
            // btnPregledOtpremnice
            // 
            this.btnPregledOtpremnice.Location = new System.Drawing.Point(22, 201);
            this.btnPregledOtpremnice.Name = "btnPregledOtpremnice";
            this.btnPregledOtpremnice.Size = new System.Drawing.Size(92, 41);
            this.btnPregledOtpremnice.TabIndex = 2;
            this.btnPregledOtpremnice.Text = "Pregled otpremnice";
            this.btnPregledOtpremnice.UseVisualStyleBackColor = true;
            this.btnPregledOtpremnice.Click += new System.EventHandler(this.btnPregledOtpremnice_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(848, 26);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(92, 41);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // otpremniceBindingSource
            // 
            this.otpremniceBindingSource.DataMember = "Otpremnice";
            this.otpremniceBindingSource.DataSource = this.otpremniceDataSet;
            // 
            // otpremniceDataSet
            // 
            this.otpremniceDataSet.DataSetName = "OtpremniceDataSet";
            this.otpremniceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpremniceTableAdapter
            // 
            this.otpremniceTableAdapter.ClearBeforeFill = true;
            // 
            // otpremniceBindingSource1
            // 
            this.otpremniceBindingSource1.DataMember = "Otpremnice";
            this.otpremniceBindingSource1.DataSource = this.otpremniceDataSet;
            // 
            // dataGridViewOtpremnice
            // 
            this.dataGridViewOtpremnice.AutoGenerateColumns = false;
            this.dataGridViewOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtpremnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rBDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.zaposleniciIDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dataGridViewOtpremnice.DataSource = this.otpremniceBindingSource2;
            this.dataGridViewOtpremnice.Location = new System.Drawing.Point(120, 85);
            this.dataGridViewOtpremnice.Name = "dataGridViewOtpremnice";
            this.dataGridViewOtpremnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOtpremnice.Size = new System.Drawing.Size(852, 341);
            this.dataGridViewOtpremnice.TabIndex = 4;
            this.dataGridViewOtpremnice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOtpremnice_CellContentClick);
            // 
            // otpremniceBindingSource2
            // 
            this.otpremniceBindingSource2.DataMember = "Otpremnice";
            this.otpremniceBindingSource2.DataSource = this.otpremniceeDataSet;
            // 
            // otpremniceeDataSet
            // 
            this.otpremniceeDataSet.DataSetName = "otpremniceeDataSet";
            this.otpremniceeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpremniceTableAdapter1
            // 
            this.otpremniceTableAdapter1.ClearBeforeFill = true;
            // 
            
            // 
            // rBDataGridViewTextBoxColumn
            // 
            this.rBDataGridViewTextBoxColumn.DataPropertyName = "RB";
            this.rBDataGridViewTextBoxColumn.HeaderText = "RB";
            this.rBDataGridViewTextBoxColumn.Name = "rBDataGridViewTextBoxColumn";
            this.rBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "Sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "Jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // zaposleniciIDDataGridViewTextBoxColumn
            // 
            this.zaposleniciIDDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenici_ID";
            this.zaposleniciIDDataGridViewTextBoxColumn.HeaderText = "Zaposlenici_ID";
            this.zaposleniciIDDataGridViewTextBoxColumn.Name = "zaposleniciIDDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // frmOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 460);
            this.Controls.Add(this.dataGridViewOtpremnice);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPregledOtpremnice);
            this.Controls.Add(this.btnBrisanjeOtpremnice);
            this.Controls.Add(this.btnKreiranjeOtpremnice);
            this.Name = "frmOtpremnice";
            this.Text = "Pregled otpremnica";
            this.Load += new System.EventHandler(this.Otpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtpremnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceeDataSet)).EndInit();
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKreiranjeOtpremnice;
        private System.Windows.Forms.Button btnBrisanjeOtpremnice;
        private System.Windows.Forms.Button btnPregledOtpremnice;
        private System.Windows.Forms.Button btnIzlaz;
        private OtpremniceDataSet otpremniceDataSet;
        private System.Windows.Forms.BindingSource otpremniceBindingSource;
        private OtpremniceDataSetTableAdapters.OtpremniceTableAdapter otpremniceTableAdapter;
        private System.Windows.Forms.BindingSource otpremniceBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewOtpremnice;
        private otpremniceeDataSet otpremniceeDataSet;
        private System.Windows.Forms.BindingSource otpremniceBindingSource2;
        private otpremniceeDataSetTableAdapters.OtpremniceTableAdapter otpremniceTableAdapter1;
        private System.Windows.Forms.BindingSource joinedBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn rBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    }
}