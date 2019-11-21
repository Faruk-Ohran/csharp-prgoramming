using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P5
{

    class Student
    {
        int[] ocjene = new int[] { 6, 9, 8, 10 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ocjene.Length; i++)
                yield return ocjene[i];
            yield return ocjene[0];
            yield return ocjene[1];
            yield return ocjene[2];
            yield return ocjene[3];
        }
    }
    public partial class Dogadjaj : Form { 
        private void button1_Click(object sender, EventArgs e)
        {
            Student IB150051 = new Student();
            foreach (var ocjene in IB150051)
            {
                MessageBox.Show($"Ocjena -> {ocjene}");
            }
            
            foreach (var slovo in "denis")
            {
                MessageBox.Show($"Slovo -> {slovo}");
            }
            //-------------------------
            var enumerator = "denis".GetEnumerator();
            while (enumerator.MoveNext())
            {
                MessageBox.Show($"Slovo -> {enumerator.Current}");
            }





            //SMSNotifikacija?.Invoke(txtPoruka.Text);
        }
    

        delegate void Notifikacija(string poruka);
        event Notifikacija SMSNotifikacija;

        delegate void NotifikacijaNadleznih(string broj, string poruka);
        event NotifikacijaNadleznih ZabranjeniUnos;


        public Dogadjaj()
        {
            InitializeComponent();
            ZabranjeniUnos += PosaljiNotifikacijuNadlzenim;
        }
        void PosaljiNotifikacijuNadlzenim(string brojTelefona, string poruka)
        {
            MessageBox.Show($"Nadlezni ->{brojTelefona} : {poruka}");
        }

        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom -> {poruka}");
        }
        void Eronet(string poruka)
        {
            MessageBox.Show($"Eronet -> {poruka}");
        }


        private void cbBHTelcom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBHTelcom.Checked)
                SMSNotifikacija += BHTelecom;
            else
                SMSNotifikacija -= BHTelecom;
        }

        private void cbEronet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEronet.Checked)
                SMSNotifikacija += Eronet;
            else
                SMSNotifikacija -= Eronet;
        }

        private void txtPoruka_TextChanged(object sender, EventArgs e)
        {
            if (txtPoruka.Text.Contains("ubiti"))
                ZabranjeniUnos("061222333", $"Koristenje zabranjene rijeci -> {txtPoruka.Text}");
        }
        private void Dogadjaj_Load(object sender, EventArgs e)
        {
            MessageBox.Show(MathUtil.Calc(x => x * x, 1,2,5,8).ToString());
            MessageBox.Show(MathUtil.Calc(Kubiraj, 1, 2, 5, 8).ToString());
        }
        int Kvadriraj(int broj) { return broj * broj; }
        int Kubiraj(int broj) => broj * broj * broj; 
    }
    delegate int Operacija(int broj);
    class MathUtil
    {
        public static int Calc(Func<int, int> operacija, params int[] brojevi)
        {
            int suma = 0;
            for (int i = 0; i < brojevi.Length; i++)
                suma += operacija(brojevi[i]);
            return suma;
        }
    }
}
