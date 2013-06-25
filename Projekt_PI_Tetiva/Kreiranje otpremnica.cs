using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PI_Tetiva
{
    public partial class frmKreiranjeOtpremnice : Form
    {
        public frmKreiranjeOtpremnice()
        {
            InitializeComponent();
        }

        private void lblSifraProizvoda_Click(object sender, EventArgs e)
        {

        }

        private void lblUnesiteKolicinu_Click(object sender, EventArgs e)
        {

        }

        private void lblUnesitePartnera_Click(object sender, EventArgs e)
        {

        }

        private void lblDokumentKreirao_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            new frmOtpremnice().Show();
            this.Hide();
        }

        private void frmKreiranjeOtpremnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artikliliiDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter1.Fill(this.artikliliiDataSet.Artikli);
            // TODO: This line of code loads data into the 'zaposleniciDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.zaposleniciDataSet.Zaposlenici);
            // TODO: This line of code loads data into the 'poslovniPartnerDataSet.PoslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.poslovniPartnerDataSet.PoslovniPartner);
            // TODO: This line of code loads data into the 'artikliDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.artikliDataSet.Artikli);
           
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            String sqlUpit = "INSERT INTO Otpremnice (Sifra, Naziv, Jedinicna_mjera, Partner, Kolicina, Zaposlenici_ID, Datum) VALUES ("+ cboSifraProizvoda.SelectedValue +", '" + txtNazivOtpremnice.Text + "', '" + txtJedinicnaMjera.Text + "', '" + cboOdaberiteSifruPartnera.SelectedValue + "' , '" + txtUnesiteKolicinu.Text + "' , '" + cboDokumentKreirao.SelectedValue + "' , { fn NOW() })";
            Spajanje.Instance.IzvrsiUpit(sqlUpit);
            new frmOtpremnice().Show();
            this.Hide();
        }
    }
}
