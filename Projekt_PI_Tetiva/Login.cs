using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Projekt_PI_Tetiva
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string sqlUpit = ("SELECT Ime,Sifra FROM Zaposlenici WHERE Ime='" + txtUsername.Text + "' and Sifra='" + txtPassword.Text + "'");

                SqlDataReader re = Spajanje.Instance.DohvatiDataReader(sqlUpit);

                //ako je pronađen upit izvrsi if
                if (re.Read())
                {
                    //spremanje imena u klasu userinformation koja je public da mogu druge forme citat
                    UserInformation.CurrentLoggedInUser = (string)re["Ime"];
                    new Glavna().Show();
                    this.Hide();
                    //MessageBox.Show("" + UserInformation.CurrentLoggedInUser);
                }
                else
                    MessageBox.Show("inavlid username and password");
                re.Close();
            }
            
        }
    }
}
//klasa da mogu u svim formama procitat ime korisnika
internal class UserInformation
{
    public static string CurrentLoggedInUser
    {
        get;
        set;
    }
}