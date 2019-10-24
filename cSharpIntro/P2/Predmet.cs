using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P2
{
    public struct Predmet
    {
        public int Semestar { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return $"{Naziv} se izvodi u {Semestar} ";
        }
    }
}
