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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacija_za_biblioteku
{
    public partial class FormKnjige : Form
    {
        List<Knjiga> list = new List<Knjiga>();
        public FormKnjige()
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
                        Knjiga knj = new Knjiga(element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value, Convert.ToInt16(element.Attribute("God. Izdavanja").Value));
                        fListaKnj.Items.Add(knj.ToString());
                        list.Add(knj);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {

            fListaKnj.Items.Clear();
            string search = fTrazi.Text;
            foreach (Knjiga knjiga in list)
            {
                if (knjiga.Izdavac.StartsWith(search) == true || knjiga.Naslov.StartsWith(search) == true || knjiga.Id.StartsWith(search) == true || knjiga.Autor.StartsWith(search) == true || search == "")
                {
                    fListaKnj.Items.Add(knjiga.ToString());
                }

            }
        }
    }
}
