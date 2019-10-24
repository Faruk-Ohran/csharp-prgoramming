using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P2
{
    public class Osoba : Bazna
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
