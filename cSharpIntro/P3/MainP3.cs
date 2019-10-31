using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
    class MainP3
    {

        public static void Run()
        {
            //PrikaziPodatke(new Student());
            //DemonstrirajLogiranje(new DBLogger());
            //DemonstrirajTemplateMetodu();
            DemonstrirajTemplateKlase();
        }

        private static void DemonstrirajTemplateKlase()
        {
            DAStudent daStudent = new DAStudent();
            
            Student student = daStudent.GetById(150051);

            Student novi = new Student();
            daStudent.Insert(novi);

        }

        static void Zamijeni<T>(ref T a, ref T b)
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

        private static void DemonstrirajLogiranje(ILogger logger)
        {
            try
            {
                throw new NotImplementedException("Ova metoda jos nije implementirana");
            }
            catch (Exception ex)
            {
                logger.Log(ex);
            }
        }

        private static void PrikaziPodatke(IPristojnost pristojnost)
        {
            Console.WriteLine(pristojnost.PredstaviSe());
        }
    }
}
