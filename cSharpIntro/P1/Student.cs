using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P1
{
    public class Student
    {
        public int Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Student(int indeks, string ime, string prezime)
        {
            Indeks = indeks;
            Ime = ime;
            Prezime = prezime;
        }
        public override string ToString()
        {
            //return indeks + " " + ime + " " + prezime;
            return $"{Indeks} {Ime} {Prezime}";
            //return base.ToString();
        }
    }
}
