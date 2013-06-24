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
    public partial class Narudzbenica : Form
    {
        public Narudzbenica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'narudzbeniceee.Narudzbenice' table. You can move, or remove it, as needed.
            this.narudzbeniceTableAdapter1.Fill(this.narudzbeniceee.Narudzbenice);
            

        }

        private void Ispis_Click(object sender, EventArgs e)
        {
            new IspisNarudzbenice().Show();
            this.Hide();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new Glavna().Show();
            this.Hide();

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {

                DataGridViewRow selektiraniRed = dataGridView1.SelectedRows[0];
            int idNarudzbenice= (int) selektiraniRed.Cells[1].Value;
           // pi2013tetivadbDataSetTableAdapters.NarudzbeniceTableAdapter tb = new pi2013tetivadbDataSetTableAdapters.NarudzbeniceTableAdapter();
            //tb.BrisanjeNarudzbenice(idNarudzbenice);
            NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter tb = new NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter();
            tb.DeleteQuery(idNarudzbenice);
                 
            dataGridView1.Rows.Remove(selektiraniRed);
            }
        }

       
        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selektiraniRed = dataGridView1.SelectedRows[0];
                int idNarudzbenice = (int)selektiraniRed.Cells[1].Value;
                NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter tb = new NarudzbeniceeeTableAdapters.NarudzbeniceTableAdapter();
                tb.UpdateQuery(idNarudzbenice);

                this.narudzbeniceTableAdapter1.Fill(this.narudzbeniceee.Narudzbenice);
                dataGridView1.Refresh();
            }
        }

       
    }
}
