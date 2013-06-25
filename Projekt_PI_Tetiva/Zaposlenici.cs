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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013tetivadbDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.pi2013tetivadbDataSet.Zaposlenici);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zaposleniciTableAdapter.FillBy(this.pi2013tetivadbDataSet.Zaposlenici);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void zaposleniciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            zaposleniciTableAdapter.Update(pi2013tetivadbDataSet.Zaposlenici);
              
        }

        private void btnDodajK_Click(object sender, EventArgs e)
        {
            new UnosZaposlenika().Show();
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new Glavna().Show();
            this.Hide();
        }

       

       
    }
}
