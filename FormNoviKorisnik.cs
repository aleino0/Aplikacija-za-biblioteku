using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.IO;

namespace Aplikacija_za_biblioteku
{
    public partial class FormNoviKorisnik : Form
    {
        List<Korisnik> list = new List<Korisnik>();

        public FormNoviKorisnik()
        {
            InitializeComponent();
            string mainFile = @"%LOCALAPPDATA%\Aplikacija_za_biblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLKorisnik = mainFile + "\\Korisnik.xml";
            
            try
            {
                using (StreamReader reader = new StreamReader(XMLKorisnik))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt64(element.Attribute("BrojTelefona").Value));
                        list.Add(kor);
                    }
                }
            }
            catch
            {
                
            }
            fImeKor.Focus();
        }

        private void btnDodajKor_Click(object sender, EventArgs e)
        {
            try
            {
            Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (Korisnik os in list)
                {
                    if (os.Id == ranID)
                    {
                        goto Rando;
                    }
                }
                Korisnik kor = new Korisnik(fImeKor.Text, fPrezimeKor.Text, fMailKor.Text, fAdresaKor.Text, Convert.ToInt64(fTelBroj.Text));
                list.Add(kor); 

                XDocument korXML = new XDocument(new XElement("Korisnike",
                        from xml in list
                        select new XElement("Korisnik",
                            new XAttribute("ID", xml.Id),
                            new XAttribute("Ime", xml.Ime),
                            new XAttribute("Prezime", xml.Prezime),
                            new XAttribute("Email", xml.Mail),
                            new XAttribute("Adresa", xml.Adresa),
                            new XAttribute("BrojTelefona", xml.Tel_broj))));
                string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
                mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                string fileStream = mainFile + "\\Korisnike.xml";
                File.Delete(fileStream); 
                File.AppendAllText(fileStream, korXML.ToString());

                MessageBox.Show("Korisnik je uspješno spremljena!", "Uspješno spremljena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
            }
            fImeKor.Clear();
            fPrezimeKor.Clear();
            fMailKor.Clear();
            fAdresaKor.Clear();
            fTelBroj.Clear();
            fImeKor.Focus();
        }
    }
}
