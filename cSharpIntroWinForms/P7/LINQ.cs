using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P7
{
    public partial class LINQ : Form
    {
        public LINQ()
        {
            InitializeComponent();
        }

        private void LanguageIntegratedQuery_Load(object sender, EventArgs e)
        {
            txtFilter.Select();
            //VarDynamic();
            //AnonimniTipoviTuple();
            //DodatneMetode();                      
        }       

        private void DodatneMetode()
        {
            string ime = "denis";
            MessageBox.Show($"FITEnkripcija -> {ime.FITEnkripcija()}");
        }

        private void AnonimniTipoviTuple()
        {
            var student = new { Indeks = 150051, Ime = "Denis" };
            var predmet = (Godina:1,Naziv:"Programiranj II",Ocjena:6);          
        }

        private void VarDynamic()
        {
            var broj = 10;
            var ime = "Denis";
            var korisnici2019 = new List<Korisnik>();

            dynamic broj2 = 30;
            broj2 = "Music";            
            broj2.NepostojecaMetoda();
            dynamic ime2 = "Denis";
        }
        

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text)) { 
                int filter = int.Parse(txtFilter.Text);
                var dobreOcjene =
                    from o in ocjene
                    where o > filter
                    select new { OcjenaNova = $"O->{o}" };
                cbDobreOcjene.DisplayMember = "OcjenaNova";
                cbDobreOcjene.DataSource = dobreOcjene.ToList();
            }
        }
        int[] ocjene = new int[] { 6, 9, 8, 6, 7, 8, 8, 10 };
        private void txtFilter_ver1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                int filter = int.Parse(txtFilter.Text);
                
                Func<int, bool> provjeraOcjena = ocjena => ocjena > filter;

                var dobreOcjene =
                   ocjene.Where(provjeraOcjena);
                cbDobreOcjene.DataSource = dobreOcjene.ToList();
            }

        }

        int Kvadriraj1(int broj) { return broj * broj; }
        int Kvadriraj2(int broj) => broj * broj; 


    }

    static class KlasaDodatnihMetoda
    {
        public static string FITEnkripcija(this string sadrzaj)
        {
            //sadrzaj =        "denis"
            string znakovi = "abcdefghijklmnoprstuvz0123456789 ";
            string zamjena = "o1bcad9ef8g6h3ij2klm5nvprstuz89*q";
            string kriptovaniSadrzaj = "";
            for (int i = 0; i < sadrzaj.Length; i++)
                kriptovaniSadrzaj += zamjena[znakovi.IndexOf(sadrzaj[i])];
            return kriptovaniSadrzaj;
        }
    }

    class AkademskaGodina { }
    //class PolozeniPredmeti { }
}
