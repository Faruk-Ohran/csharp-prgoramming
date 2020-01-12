using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace cSharpIntroWinForms.P11
{
    public partial class Izvjestaji : Form
    {
        private Korisnik korisnik;

        public Izvjestaji()
        {
            InitializeComponent();
        }

        public Izvjestaji(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void Izvjestaji_Load(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ImePrezime", $"{korisnik.Ime} {korisnik.Prezime}"));
                rpc.Add(new ReportParameter("Indeks", korisnik.KorisnickoIme));


                DSDLWMS.TblPolozeniDataTable tbl = new DSDLWMS.TblPolozeniDataTable();
                int i = 1;

                List<object> list = new List<object>();

                foreach (var polozeni in korisnik.Uspjeh)
                {

                    list.Add(new
                    {
                        Rb = i++,
                        Naziv = polozeni.Predmet.Naziv,
                        Ocjena = polozeni.Ocjena,
                        Datum = polozeni.Datum
                    });
                    //DSDLWMS.TblPolozeniRow red = tbl.NewTblPolozeniRow();
                    //red.Rb = i++;
                    //red.Naziv = polozeni.Predmet.Naziv;
                    //red.Ocjena = polozeni.Ocjena;
                    //red.Datum = polozeni.Datum;
                    //tbl.Rows.Add(red);
                }



                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DLWMS";
                rds.Value = list;

                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
