using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Narudzbenice : Form
    {
        public Narudzbenice()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new tetiva.glavna().Show();
            this.Hide();
        }

        private void btnIspisNarudzbenice_Click(object sender, EventArgs e)
        {
            
        }
    }
}
