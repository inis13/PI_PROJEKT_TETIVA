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
    public partial class IspisNarudzbenice : Form
    {
        public IspisNarudzbenice()
        {
            InitializeComponent();
        }

        private void IspisNarudzbenice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportNarudzbenice.Narudzbenice' table. You can move, or remove it, as needed.
            this.narudzbeniceTableAdapter.Fill(this.reportNarudzbenice.Narudzbenice);

            this.reportViewer1.RefreshReport();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new Narudzbenica().Show();
            this.Hide();
        }
    }
}
