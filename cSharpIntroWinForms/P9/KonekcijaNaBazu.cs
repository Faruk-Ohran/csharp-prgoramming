using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.P9
{
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu(): base("PutanjaDoBaze")
        {

        }
        public DbSet<Studenti> Studenti { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }

    }

    [Table("Studenti")]
    public class Studenti
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
    }

}
