using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
    class Student : IPristojnost
    {
        public string PredstaviSe()
        {
            return "Poštovanje, ja sam .... student FIT-a u Mostaru ";
        }
    }
}
