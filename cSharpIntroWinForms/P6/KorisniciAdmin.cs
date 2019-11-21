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
    public partial class KorisniciAdmin : Form
    {
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            if (registracija.ShowDialog() == DialogResult.OK)
                LoadData();

        }

        private void dgvKorisnici_MouseClick(object sender, MouseEventArgs e)
        {
            Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if (korisnik != null)
            {
                Registracija registracija = new Registracija(korisnik);
                registracija.ShowDialog();
                LoadData();
            }

        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici ?? DBInMemory.RegistrovaniKorisnici;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();
            List<Korisnik> rezultat = new List<Korisnik>();
            foreach (var korisnik in DBInMemory.RegistrovaniKorisnici)
            {
                if (korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter))
                    rezultat.Add(korisnik);
            }
            LoadData(rezultat);
            
        }
    }
}
