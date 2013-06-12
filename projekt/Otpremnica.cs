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
    public partial class Otpremnica : Form
    {
        public Otpremnica()
        {
            InitializeComponent();
        }

        private void Otpremnica_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new tetiva.glavna().Show();
            this.Hide();
        }

        private void btnIspisOtpremnice_Click(object sender, EventArgs e)
        {
            //prikazuje ispis otpremnice
            new PI.frmIspisOtpremnice().Show();
            this.Hide();
        }
    }
}
