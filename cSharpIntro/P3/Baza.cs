using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
    class Baza <T> where T : class
    {
        DBKonekcija db { get; set; }
        public Baza()
        {
            db = new DBKonekcija();
        }

        public T GetById(int id){ return null; }
        public int Insert(T obj) { return 0; }
    }
}
