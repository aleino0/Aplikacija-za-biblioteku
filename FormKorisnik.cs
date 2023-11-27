using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacija_za_biblioteku
{
    public partial class FormKorisnik : Form
    {

        List<Korisnik> list = new List<Korisnik>();
        public FormKorisnik()
        {
            InitializeComponent();
            string mainFile = @"%LOCALAPPDATA%\Aplikacija_za_biblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLKorisnik = mainFile + "\\Korisnike.xml";
            try
            {
                using (StreamReader reader = new StreamReader(XMLKorisnik))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt64(element.Attribute("BrojTelefona").Value));
                        fListKor.Items.Add(kor.ToString());
                        list.Add(kor);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            fListKor.Items.Clear();
            string search = ftraziKor.Text;
            foreach (Korisnik korisnik in list)
            {
                if (korisnik.Ime.StartsWith(search) == true || korisnik.Prezime.StartsWith(search) == true || korisnik.Adresa.StartsWith(search) == true || korisnik.Mail.StartsWith(search) == true || Convert.ToString(korisnik.Tel_broj).StartsWith(search) == true || korisnik.Id.StartsWith(search) == true || search == "")
                {
                    fListKor.Items.Add(korisnik.ToString());
                }

            }


            FormNoviKorisnik frm = new FormNoviKorisnik();
            DialogResult rez = frm.ShowDialog();
        }
    }
}
