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
    public partial class UnosZaposlenika : Form
    {
        public UnosZaposlenika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlUpit = "";

sqlUpit = "INSERT INTO Zaposlenici (Ime, Prezime, Sifra) VALUES ('" + txtIme.Text + "','" + txtPrezime.Text + "','" + txtSifra.Text + "')";

Spajanje.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
