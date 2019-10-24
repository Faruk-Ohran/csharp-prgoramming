using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P2
{
    public class Student : Osoba
    {      

        public int Indeks { get; set; }       

        int[] Ocjene = new int[40];

        public int this [int lokacija] { 
            get { return Ocjene[lokacija]; }
            set { Ocjene[lokacija] = value; }
        }
        public Student(int indeks, string ime, string prezime) : base(ime, prezime)
        {
            Indeks = indeks;            
        }

        public void Deconstruct(out int indeks, out string ime, out string prezime)
        {
            indeks = Indeks;
            ime = Ime;
            prezime = Prezime;
        }
        public override string ToString()
        {
            return $"{Indeks} {base.ToString()} {string.Join(",",Ocjene)}";
        }
    }
}
