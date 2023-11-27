using AplikacijaZaBiblioteku;
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

namespace Aplikacija_za_biblioteku
{
    public partial class FormNovaKnjiga : Form
    {
        List<Knjiga> list = new List<Knjiga>();
        public FormNovaKnjiga()
        {
            InitializeComponent();
            string mainFile = @"%LOCALAPPDATA%\Aplikacija_za_biblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLknjiga = mainFile + "\\Knjige.xml";
            try
            {
                using (StreamReader reader = new StreamReader(XMLknjiga))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Knjiga knj = new Knjiga(element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value, Convert.ToInt16(element.Attribute("GodIzdavanja").Value));
                        list.Add(knj);
                    }
                }
            }
            catch
            {
            }
            fAutor.Focus();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
            Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (Knjiga os in list)
                {
                    if (os.Id == ranID)
                    {
                        goto Rando;
                    }
                }
                Knjiga knj = new Knjiga(fAutor.Text, fNaslov.Text, fIzdavac.Text, Convert.ToInt16(fGodIzd.Text));
                list.Add(knj); 

                XDocument knjXML = new XDocument(new XElement("Knjige",
                        from xml in list
                        select new XElement("Knjige",
                            new XAttribute("ID", xml.Id),
                            new XAttribute("Author", xml.Autor),
                            new XAttribute("Naslov", xml.Naslov),
                            new XAttribute("Izdavac", xml.Izdavac),
                            new XAttribute("God. Izdavanja", xml.GodIzdavanja))));
                string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
                mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                string fileStream = mainFile + "\\Knjige.xml";
                File.Delete(fileStream); 
                File.AppendAllText(fileStream, knjXML.ToString());

                MessageBox.Show("Knjiga je uspješno spremljena!", "Uspješno spremljena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("Greška\r\n" + n, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fAutor.Clear();
            fNaslov.Clear();
            fIzdavac.Clear();
            fGodIzd.Clear();
            fAutor.Focus();
        }

    }
}