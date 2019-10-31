using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
    interface IPristojnost
    {
        string PredstaviSe();
    }
    class Student : IPristojnost
    {
        public string PredstaviSe()
        {
            return "Poštovanje, ja sam .... student FIT-a u Mostaru ";
        }
    }
    class Ucenik : IPristojnost
    {
        public string PredstaviSe()
        {
            return "Zdravo, moje ime je .... i ucenik sam srednje skole";
        }
    }
}
