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
    public partial class ReportOtpremnica : Form
    {
        public ReportOtpremnica()
        {
            InitializeComponent();
        }

        private void ReportOtpremnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportOtpremnice.Otpremnice' table. You can move, or remove it, as needed.
            this.otpremniceTableAdapter1.Fill(this.reportOtpremnice.Otpremnice);
            // TODO: This line of code loads data into the 'pi2013tetivadbDataSet1.Zaposlenici' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'pi2013tetivadbDataSet.Otpremnice' table. You can move, or remove it, as needed.
            this.otpremniceTableAdapter.Fill(this.pi2013tetivadbDataSet.Otpremnice);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            new frmOtpremnice().Show();
            this.Hide();
        }

      
    }
}
