using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms
{
    class DBInMemory
    {
        public static List<Korisnik> RegistrovaniKorisnici { get; set; }
        static DBInMemory()
        {
            RegistrovaniKorisnici = new List<Korisnik>();
            DodajPodrazumijevaneKorisnike();
        }

        private static void DodajPodrazumijevaneKorisnike()
        {
            Korisnik k1 = new Korisnik() { Id = 1, Ime = "Denis", Prezime = "Music", KorisnickoIme = "denis", Lozinka = "denis" };
            Korisnik k2 = new Korisnik() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", KorisnickoIme = "jasmin", Lozinka = "jasmin" };
            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }


}
