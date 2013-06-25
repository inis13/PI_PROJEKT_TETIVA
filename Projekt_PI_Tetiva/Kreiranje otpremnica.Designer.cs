namespace Projekt_PI_Tetiva
{
    partial class frmKreiranjeOtpremnice
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
            this.lblSifraProizvoda = new System.Windows.Forms.Label();
            this.lblUnesitePartnera = new System.Windows.Forms.Label();
            this.lblUnesiteKolicinu = new System.Windows.Forms.Label();
            this.lblDokumentKreirao = new System.Windows.Forms.Label();
            this.cboSifraProizvoda = new System.Windows.Forms.ComboBox();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliDataSet = new Projekt_PI_Tetiva.artikliDataSet();
            this.cboDokumentKreirao = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposleniciDataSet = new Projekt_PI_Tetiva.ZaposleniciDataSet();
            this.txtUnesiteKolicinu = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.lblNazivOtpremnice = new System.Windows.Forms.Label();
            this.txtNazivOtpremnice = new System.Windows.Forms.TextBox();
            this.lblJedinicnaMjera = new System.Windows.Forms.Label();
            this.txtJedinicnaMjera = new System.Windows.Forms.TextBox();
            this.cboOdaberiteSifruPartnera = new System.Windows.Forms.ComboBox();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartnerDataSet = new Projekt_PI_Tetiva.PoslovniPartnerDataSet();
            this.artikliTableAdapter = new Projekt_PI_Tetiva.artikliDataSetTableAdapters.ArtikliTableAdapter();
            this.poslovniPartnerTableAdapter = new Projekt_PI_Tetiva.PoslovniPartnerDataSetTableAdapters.PoslovniPartnerTableAdapter();
            this.zaposleniciTableAdapter = new Projekt_PI_Tetiva.ZaposleniciDataSetTableAdapters.ZaposleniciTableAdapter();
            this.artikliliiDataSet = new Projekt_PI_Tetiva.artikliliiDataSet();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter1 = new Projekt_PI_Tetiva.artikliliiDataSetTableAdapters.ArtikliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliliiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifraProizvoda
            // 
            this.lblSifraProizvoda.AutoSize = true;
            this.lblSifraProizvoda.Location = new System.Drawing.Point(52, 102);
            this.lblSifraProizvoda.Name = "lblSifraProizvoda";
            this.lblSifraProizvoda.Size = new System.Drawing.Size(124, 13);
            this.lblSifraProizvoda.TabIndex = 0;
            this.lblSifraProizvoda.Text = "Odaberite šifru proizvoda";
            this.lblSifraProizvoda.Click += new System.EventHandler(this.lblSifraProizvoda_Click);
            // 
            // lblUnesitePartnera
            // 
            this.lblUnesitePartnera.AutoSize = true;
            this.lblUnesitePartnera.Location = new System.Drawing.Point(52, 131);
            this.lblUnesitePartnera.Name = "lblUnesitePartnera";
            this.lblUnesitePartnera.Size = new System.Drawing.Size(117, 13);
            this.lblUnesitePartnera.TabIndex = 1;
            this.lblUnesitePartnera.Text = "Odaberite šifru partnera";
            this.lblUnesitePartnera.Click += new System.EventHandler(this.lblUnesitePartnera_Click);
            // 
            // lblUnesiteKolicinu
            // 
            this.lblUnesiteKolicinu.AutoSize = true;
            this.lblUnesiteKolicinu.Location = new System.Drawing.Point(52, 160);
            this.lblUnesiteKolicinu.Name = "lblUnesiteKolicinu";
            this.lblUnesiteKolicinu.Size = new System.Drawing.Size(82, 13);
            this.lblUnesiteKolicinu.TabIndex = 2;
            this.lblUnesiteKolicinu.Text = "Unesite količinu";
            this.lblUnesiteKolicinu.Click += new System.EventHandler(this.lblUnesiteKolicinu_Click);
            // 
            // lblDokumentKreirao
            // 
            this.lblDokumentKreirao.AutoSize = true;
            this.lblDokumentKreirao.Location = new System.Drawing.Point(52, 224);
            this.lblDokumentKreirao.Name = "lblDokumentKreirao";
            this.lblDokumentKreirao.Size = new System.Drawing.Size(91, 13);
            this.lblDokumentKreirao.TabIndex = 3;
            this.lblDokumentKreirao.Text = "Dokument kreirao";
            this.lblDokumentKreirao.Click += new System.EventHandler(this.lblDokumentKreirao_Click);
            // 
            // cboSifraProizvoda
            // 
            this.cboSifraProizvoda.DataSource = this.artikliBindingSource1;
            this.cboSifraProizvoda.DisplayMember = "Naziv";
            this.cboSifraProizvoda.FormattingEnabled = true;
            this.cboSifraProizvoda.Location = new System.Drawing.Point(182, 94);
            this.cboSifraProizvoda.Name = "cboSifraProizvoda";
            this.cboSifraProizvoda.Size = new System.Drawing.Size(121, 21);
            this.cboSifraProizvoda.TabIndex = 4;
            this.cboSifraProizvoda.ValueMember = "ID_artikla";
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.artikliDataSet;
            // 
            // artikliDataSet
            // 
            this.artikliDataSet.DataSetName = "artikliDataSet";
            this.artikliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboDokumentKreirao
            // 
            this.cboDokumentKreirao.DataSource = this.zaposleniciBindingSource;
            this.cboDokumentKreirao.DisplayMember = "Prezime";
            this.cboDokumentKreirao.FormattingEnabled = true;
            this.cboDokumentKreirao.Location = new System.Drawing.Point(182, 224);
            this.cboDokumentKreirao.Name = "cboDokumentKreirao";
            this.cboDokumentKreirao.Size = new System.Drawing.Size(121, 21);
            this.cboDokumentKreirao.TabIndex = 5;
            this.cboDokumentKreirao.ValueMember = "IDkorisnik";
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.zaposleniciDataSet;
            // 
            // zaposleniciDataSet
            // 
            this.zaposleniciDataSet.DataSetName = "ZaposleniciDataSet";
            this.zaposleniciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUnesiteKolicinu
            // 
            this.txtUnesiteKolicinu.Location = new System.Drawing.Point(182, 160);
            this.txtUnesiteKolicinu.Name = "txtUnesiteKolicinu";
            this.txtUnesiteKolicinu.Size = new System.Drawing.Size(121, 20);
            this.txtUnesiteKolicinu.TabIndex = 6;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(75, 274);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(94, 40);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(182, 274);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(94, 40);
            this.btnSpremiPromjene.TabIndex = 9;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // lblNazivOtpremnice
            // 
            this.lblNazivOtpremnice.AutoSize = true;
            this.lblNazivOtpremnice.Location = new System.Drawing.Point(52, 71);
            this.lblNazivOtpremnice.Name = "lblNazivOtpremnice";
            this.lblNazivOtpremnice.Size = new System.Drawing.Size(89, 13);
            this.lblNazivOtpremnice.TabIndex = 10;
            this.lblNazivOtpremnice.Text = "Naziv otpremnice";
            // 
            // txtNazivOtpremnice
            // 
            this.txtNazivOtpremnice.Location = new System.Drawing.Point(182, 64);
            this.txtNazivOtpremnice.Name = "txtNazivOtpremnice";
            this.txtNazivOtpremnice.Size = new System.Drawing.Size(121, 20);
            this.txtNazivOtpremnice.TabIndex = 11;
            // 
            // lblJedinicnaMjera
            // 
            this.lblJedinicnaMjera.AutoSize = true;
            this.lblJedinicnaMjera.Location = new System.Drawing.Point(55, 191);
            this.lblJedinicnaMjera.Name = "lblJedinicnaMjera";
            this.lblJedinicnaMjera.Size = new System.Drawing.Size(80, 13);
            this.lblJedinicnaMjera.TabIndex = 12;
            this.lblJedinicnaMjera.Text = "Jedinična mjera";
            // 
            // txtJedinicnaMjera
            // 
            this.txtJedinicnaMjera.Location = new System.Drawing.Point(182, 191);
            this.txtJedinicnaMjera.Name = "txtJedinicnaMjera";
            this.txtJedinicnaMjera.Size = new System.Drawing.Size(121, 20);
            this.txtJedinicnaMjera.TabIndex = 13;
            // 
            // cboOdaberiteSifruPartnera
            // 
            this.cboOdaberiteSifruPartnera.DataSource = this.poslovniPartnerBindingSource;
            this.cboOdaberiteSifruPartnera.DisplayMember = "Naziv";
            this.cboOdaberiteSifruPartnera.FormattingEnabled = true;
            this.cboOdaberiteSifruPartnera.Location = new System.Drawing.Point(182, 131);
            this.cboOdaberiteSifruPartnera.Name = "cboOdaberiteSifruPartnera";
            this.cboOdaberiteSifruPartnera.Size = new System.Drawing.Size(121, 21);
            this.cboOdaberiteSifruPartnera.TabIndex = 14;
            this.cboOdaberiteSifruPartnera.ValueMember = "ID_dobavljac";
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataMember = "PoslovniPartner";
            this.poslovniPartnerBindingSource.DataSource = this.poslovniPartnerDataSet;
            // 
            // poslovniPartnerDataSet
            // 
            this.poslovniPartnerDataSet.DataSetName = "PoslovniPartnerDataSet";
            this.poslovniPartnerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // poslovniPartnerTableAdapter
            // 
            this.poslovniPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // artikliliiDataSet
            // 
            this.artikliliiDataSet.DataSetName = "artikliliiDataSet";
            this.artikliliiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this.artikliliiDataSet;
            // 
            // artikliTableAdapter1
            // 
            this.artikliTableAdapter1.ClearBeforeFill = true;
            // 
            // frmKreiranjeOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 369);
            this.Controls.Add(this.cboOdaberiteSifruPartnera);
            this.Controls.Add(this.txtJedinicnaMjera);
            this.Controls.Add(this.lblJedinicnaMjera);
            this.Controls.Add(this.txtNazivOtpremnice);
            this.Controls.Add(this.lblNazivOtpremnice);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtUnesiteKolicinu);
            this.Controls.Add(this.cboDokumentKreirao);
            this.Controls.Add(this.cboSifraProizvoda);
            this.Controls.Add(this.lblDokumentKreirao);
            this.Controls.Add(this.lblUnesiteKolicinu);
            this.Controls.Add(this.lblUnesitePartnera);
            this.Controls.Add(this.lblSifraProizvoda);
            this.Name = "frmKreiranjeOtpremnice";
            this.Text = "Kreiranje otpremnice";
            this.Load += new System.EventHandler(this.frmKreiranjeOtpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliliiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifraProizvoda;
        private System.Windows.Forms.Label lblUnesitePartnera;
        private System.Windows.Forms.Label lblUnesiteKolicinu;
        private System.Windows.Forms.Label lblDokumentKreirao;
        private System.Windows.Forms.ComboBox cboSifraProizvoda;
        private System.Windows.Forms.ComboBox cboDokumentKreirao;
        private System.Windows.Forms.TextBox txtUnesiteKolicinu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Label lblNazivOtpremnice;
        private System.Windows.Forms.TextBox txtNazivOtpremnice;
        private System.Windows.Forms.Label lblJedinicnaMjera;
        private System.Windows.Forms.TextBox txtJedinicnaMjera;
        private System.Windows.Forms.ComboBox cboOdaberiteSifruPartnera;
        private artikliDataSet artikliDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private artikliDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private PoslovniPartnerDataSet poslovniPartnerDataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private PoslovniPartnerDataSetTableAdapters.PoslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private ZaposleniciDataSet zaposleniciDataSet;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private ZaposleniciDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private artikliliiDataSet artikliliiDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private artikliliiDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter1;
  

    }
}