using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                Korisnik noviKorisnik = new Korisnik()
                {
                    Id = DBInMemory.RegistrovaniKorisnici.Count + 1,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };
                DBInMemory.RegistrovaniKorisnici.Add(noviKorisnik);
                MessageBox.Show("Registracija je uspješna!");
                Close();
            }
        }

       
        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtIme, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(txtPrezime, err, Validator.porObaveznaVrijednost);            
        }

        private string GenerisiLozinku(int brojZnakova)
        {
            string novaLozinka = string.Empty;
            string dozvoljeniZnakovi = "as#$kdjas94oighs2387239058aijfh!%&/()";
            Random random = new Random();
            int lokacija = 0;
            for (int i = 0; i < brojZnakova; i++)
            {
                lokacija = random.Next(0, dozvoljeniZnakovi.Length);
                novaLozinka += dozvoljeniZnakovi[lokacija];
            }

            return novaLozinka;
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";

        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            txtLozinka.Text = GenerisiLozinku(12);
        }
    }
}
