namespace Projekt_PI_Tetiva
{
    partial class IspisNarudzbenice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPopisNarudzbenica = new System.Windows.Forms.Label();
            this.reportNarudzbenice = new Projekt_PI_Tetiva.reportNarudzbenice();
            this.narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeniceTableAdapter = new Projekt_PI_Tetiva.reportNarudzbeniceTableAdapters.NarudzbeniceTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pi2013tetivadbDataSet = new Projekt_PI_Tetiva.pi2013tetivadbDataSet();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.narudzbeniceBindingSource;
            this.comboBox1.DisplayMember = "Naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Sifra";
            // 
            // lblPopisNarudzbenica
            // 
            this.lblPopisNarudzbenica.AutoSize = true;
            this.lblPopisNarudzbenica.Location = new System.Drawing.Point(22, 9);
            this.lblPopisNarudzbenica.Name = "lblPopisNarudzbenica";
            this.lblPopisNarudzbenica.Size = new System.Drawing.Size(102, 13);
            this.lblPopisNarudzbenica.TabIndex = 1;
            this.lblPopisNarudzbenica.Text = "Popis Narudzbenica";
            // 
            // reportNarudzbenice
            // 
            this.reportNarudzbenice.DataSetName = "reportNarudzbenice";
            this.reportNarudzbenice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceBindingSource
            // 
            this.narudzbeniceBindingSource.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource.DataSource = this.reportNarudzbenice;
            // 
            // narudzbeniceTableAdapter
            // 
            this.narudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetNarudzbenice";
            reportDataSource1.Value = this.narudzbeniceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projekt_PI_Tetiva.IzvjestajNarudzbenice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 321);
            this.reportViewer1.TabIndex = 2;
            // 
            // pi2013tetivadbDataSet
            // 
            this.pi2013tetivadbDataSet.DataSetName = "pi2013tetivadbDataSet";
            this.pi2013tetivadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(484, 25);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(126, 34);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // IspisNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 417);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblPopisNarudzbenica);
            this.Controls.Add(this.comboBox1);
            this.Name = "IspisNarudzbenice";
            this.Text = "IspisNarudzbenice";
            this.Load += new System.EventHandler(this.IspisNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPopisNarudzbenica;
        private reportNarudzbenice reportNarudzbenice;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource;
        private reportNarudzbeniceTableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pi2013tetivadbDataSet pi2013tetivadbDataSet;
        private System.Windows.Forms.Button btnIzlaz;
    }
}