namespace Projekt_PI_Tetiva
{
    partial class ReportOtpremnica
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
            this.otpremniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013tetivadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013tetivadbDataSet = new Projekt_PI_Tetiva.pi2013tetivadbDataSet();
            this.otpremniceTableAdapter = new Projekt_PI_Tetiva.pi2013tetivadbDataSetTableAdapters.OtpremniceTableAdapter();
            this.pi2013tetivadbDataSet1 = new Projekt_PI_Tetiva.pi2013tetivadbDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.otpremniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportOtpremnice = new Projekt_PI_Tetiva.reportOtpremnice();
            this.lblOtpremnice = new System.Windows.Forms.Label();
            this.otpremniceTableAdapter1 = new Projekt_PI_Tetiva.reportOtpremniceTableAdapters.OtpremniceTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // otpremniceBindingSource
            // 
            this.otpremniceBindingSource.DataMember = "Otpremnice";
            this.otpremniceBindingSource.DataSource = this.pi2013tetivadbDataSetBindingSource;
            // 
            // pi2013tetivadbDataSetBindingSource
            // 
            this.pi2013tetivadbDataSetBindingSource.DataSource = this.pi2013tetivadbDataSet;
            this.pi2013tetivadbDataSetBindingSource.Position = 0;
            // 
            // pi2013tetivadbDataSet
            // 
            this.pi2013tetivadbDataSet.DataSetName = "pi2013tetivadbDataSet";
            this.pi2013tetivadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpremniceTableAdapter
            // 
            this.otpremniceTableAdapter.ClearBeforeFill = true;
            // 
            // pi2013tetivadbDataSet1
            // 
            this.pi2013tetivadbDataSet1.DataSetName = "pi2013tetivadbDataSet";
            this.pi2013tetivadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.otpremniceBindingSource1;
            this.comboBox1.DisplayMember = "Naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "RB";
            // 
            // otpremniceBindingSource1
            // 
            this.otpremniceBindingSource1.DataMember = "Otpremnice";
            this.otpremniceBindingSource1.DataSource = this.reportOtpremnice;
            // 
            // reportOtpremnice
            // 
            this.reportOtpremnice.DataSetName = "reportOtpremnice";
            this.reportOtpremnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOtpremnice
            // 
            this.lblOtpremnice.AutoSize = true;
            this.lblOtpremnice.Location = new System.Drawing.Point(39, 9);
            this.lblOtpremnice.Name = "lblOtpremnice";
            this.lblOtpremnice.Size = new System.Drawing.Size(88, 13);
            this.lblOtpremnice.TabIndex = 1;
            this.lblOtpremnice.Text = "Popis otpremnica";
            // 
            // otpremniceTableAdapter1
            // 
            this.otpremniceTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projekt_PI_Tetiva.Pregled otpremnice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(601, 293);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(508, 40);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // ReportOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 385);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblOtpremnice);
            this.Controls.Add(this.comboBox1);
            this.Name = "ReportOtpremnica";
            this.Text = "ReportOtpremnica";
            this.Load += new System.EventHandler(this.ReportOtpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013tetivadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOtpremnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pi2013tetivadbDataSet pi2013tetivadbDataSet;
        private System.Windows.Forms.BindingSource pi2013tetivadbDataSetBindingSource;
        private System.Windows.Forms.BindingSource otpremniceBindingSource;
        private pi2013tetivadbDataSetTableAdapters.OtpremniceTableAdapter otpremniceTableAdapter;
        private pi2013tetivadbDataSet pi2013tetivadbDataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblOtpremnice;
        private reportOtpremnice reportOtpremnice;
        private System.Windows.Forms.BindingSource otpremniceBindingSource1;
        private reportOtpremniceTableAdapters.OtpremniceTableAdapter otpremniceTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnIzlaz;
    }
}