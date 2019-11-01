using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
    class MainP3
    {

        public static void Run()
        {
            //PrikaziPodatke();
            //DemonstrirajLogiranje();
            //DemonstrirajTemplateMetodu();
            //DemonstrirajTemplateKlase();
        }

        private static void DemonstrirajTemplateKlase()
        {

            //Baza<int> valueVrijednosti = new Baza<int>();//u klasi smo naveli da T mogu biti samo reference

            DAStudent daStudent = new DAStudent();
            
            Student student = daStudent.GetById(150051);

            Student novi = new Student();
            daStudent.Insert(novi);

        }

        private static void Zamijeni<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private static void DemonstrirajTemplateMetodu()
        {
            int a = 33, b = 66;
            Console.WriteLine($"{a} {b}");
            Zamijeni(ref a, ref b);
            Console.WriteLine($"{a} {b}");
        }

        private static void DemonstrirajLogiranje()
        {
            MetodaUKojojNastajeIzuzetak(new FileLogger());
            MetodaUKojojNastajeIzuzetak(new DBLogger());
        }

        private static void MetodaUKojojNastajeIzuzetak(ILogger logger)
        {
            try
            {
                throw new NotImplementedException($"{DateTime.Now.ToString()} -> Servis nije dostuopan...");
            }
            catch (Exception ex)
            {
                logger.Log(ex);
            }
        }

        private static void PrikaziPodatke()
        {
            PredstaviSe(new Student());
            PredstaviSe(new Ucenik());
        }

        private static void PredstaviSe(IPristojnost pristojnost)
        {
            Console.WriteLine(pristojnost.PredstaviSe());
        }
    }
}
