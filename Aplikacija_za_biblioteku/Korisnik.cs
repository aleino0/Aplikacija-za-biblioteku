using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aplikacija_za_biblioteku
{
    class Korisnik
    {
        Random id = new Random();
        string ime;
        string prezime;
        string mail;
        string adresa;
        int tel_broj;

        public Korisnik(string ime, string prezime, string mail, string adresa, int tel_broj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.mail = mail;
            this.adresa = adresa;
            this.tel_broj = tel_broj;


            string s = "<xml>" + id + ime + prezime + mail + adresa + tel_broj + "</xml>";
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(s);
            xdoc.Save("Korisnici.xml");
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int Tel_broj { get => tel_broj; set => tel_broj = value; }
    }
}
