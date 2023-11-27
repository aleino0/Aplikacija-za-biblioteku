using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_za_biblioteku
{
    public partial class FormNoviKorisnik : Form
    {
        public FormNoviKorisnik()
        {
            InitializeComponent();
        }

        private void btnDodajKor_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik(fImeKor.Text, fPrezimeKor.Text, fMailKor.Text, fAdresaKor.Text, Convert.ToInt32(fTelBroj.Text));
        }
    }
}
