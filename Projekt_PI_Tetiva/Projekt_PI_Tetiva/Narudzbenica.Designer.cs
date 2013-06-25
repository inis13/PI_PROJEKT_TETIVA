namespace Projekt_PI_Tetiva
{
    partial class Narudzbenica
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odobrenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeniceee = new Projekt_PI_Tetiva.Narudzbeniceee();
            this.narudzbeniceTableAdapter1 = new Projekt_PI_Tetiva.NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(741, 25);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(82, 32);
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(33, 73);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(88, 35);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispis narudzbenice";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.Ispis_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(33, 124);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(88, 36);
            this.btnOdobri.TabIndex = 2;
            this.btnOdobri.Text = "Odobri narudzbenicu";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(33, 175);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(88, 36);
            this.btnBrisanje.TabIndex = 3;
            this.btnBrisanje.Text = "Brisanje narudzbenice";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // narudzbeniceBindingSource
            // 
            this.narudzbeniceBindingSource.DataMember = "Narudzbenice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rBDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn,
            this.odobrenoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbeniceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(127, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 253);
            this.dataGridView1.TabIndex = 4;
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
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            // 
            // odobrenoDataGridViewTextBoxColumn
            // 
            this.odobrenoDataGridViewTextBoxColumn.DataPropertyName = "Odobreno";
            this.odobrenoDataGridViewTextBoxColumn.HeaderText = "Odobreno";
            this.odobrenoDataGridViewTextBoxColumn.Name = "odobrenoDataGridViewTextBoxColumn";
            // 
            // narudzbeniceBindingSource1
            // 
            this.narudzbeniceBindingSource1.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource1.DataSource = this.narudzbeniceee;
            // 
            // narudzbeniceee
            // 
            this.narudzbeniceee.DataSetName = "Narudzbeniceee";
            this.narudzbeniceee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceTableAdapter1
            // 
            this.narudzbeniceTableAdapter1.ClearBeforeFill = true;
            // 
            // Narudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "Narudzbenica";
            this.Text = "Narudzbenica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnBrisanje;
       
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource;
        
        private System.Windows.Forms.BindingSource narudzbenicaDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Narudzbeniceee narudzbeniceee;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource1;
        private NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odobrenoDataGridViewTextBoxColumn;
    }
}