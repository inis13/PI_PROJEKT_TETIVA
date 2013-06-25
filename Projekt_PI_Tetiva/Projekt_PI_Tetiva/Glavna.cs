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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Pocetna().Show();
            this.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Zaposlenici().Show();
            this.Hide();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }


    }
}
