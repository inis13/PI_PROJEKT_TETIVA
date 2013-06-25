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
    public partial class frmOtpremnice : Form
    {
        public frmOtpremnice()
        {
            InitializeComponent();
        }

 

        private void Otpremnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otpremniceeDataSet.Otpremnice' table. You can move, or remove it, as needed.
            this.otpremniceTableAdapter1.Fill(this.otpremniceeDataSet.Otpremnice);
            // TODO: This line of code loads data into the 'otpremniceDataSet.Otpremnice' table. You can move, or remove it, as needed.
            this.otpremniceTableAdapter.Fill(this.otpremniceDataSet.Otpremnice);

        }

        private void btnKreiranjeOtpremnice_Click(object sender, EventArgs e)
        {
            new frmKreiranjeOtpremnice().Show();
            this.Hide();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new Glavna().Show();
            this.Hide();
        }

        private void btnBrisanjeOtpremnice_Click(object sender, EventArgs e)
        {
            if (dataGridViewOtpremnice.SelectedRows.Count > 0)
            {
                DataGridViewRow selektiraniRed = dataGridViewOtpremnice.SelectedRows[0];
                int idOtpremnice = (int)selektiraniRed.Cells[1].Value;
                pi2013tetivadbDataSetTableAdapters.OtpremniceTableAdapter tb = new pi2013tetivadbDataSetTableAdapters.OtpremniceTableAdapter();
                tb.DeleteOtpremnica(idOtpremnice);
                dataGridViewOtpremnice.Rows.Remove(selektiraniRed);
            }
        }

        private void dataGridViewOtpremnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPregledOtpremnice_Click(object sender, EventArgs e)
        {
            

            if (dataGridViewOtpremnice.SelectedRows.Count > 0)
            {
                DataGridViewRow selektiraniRed = dataGridViewOtpremnice.SelectedRows[0];
                int idOtpremnice = (int)selektiraniRed.Cells[1].Value;
                new ReportOtpremnica().Show();
                this.Hide();
            }
        }

        private void dataGridViewOtpremnice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
