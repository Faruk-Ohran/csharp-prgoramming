using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = DBInMemory.NPP2018;
            cmbPredmeti.DisplayMember = "Naziv";
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Polozeni;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            try
            {
                PolozeniPredmet polozeniPredmet = new PolozeniPredmet();
                polozeniPredmet.Id = korisnik.Polozeni.Count + 1;
                polozeniPredmet.Predmet = cmbPredmeti.SelectedItem as Predmet;
                polozeniPredmet.Ocjena = int.Parse(txtOcjena.Text);
                polozeniPredmet.DatumPolaganja = dtpDatumPolaganja.Value;
                korisnik.Polozeni.Add(polozeniPredmet);
                UcitajPolozenePredmete();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
