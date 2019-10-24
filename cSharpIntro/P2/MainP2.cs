using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P2
{   
    public class MainP2
    {
        public static void Run()
        {
            //ValueVsReference();
            //PodrazumijevaneVrijednosti();
            //ProslijedjivanjeParametara();
            //PozoviDeconstruct();
            //DemonstrirajParams();
            //NullProvjera("Denis Music");
            //DemonstrirajIndeksere();

            Bazna b = new Student(0, "", "");

        }

        private static void DemonstrirajIndeksere()
        {
            Student student = new Student(190000, "Denis", "Music");
            student[0] = 9;
            student[1] = 6;
            student[2] = 7;
            Console.WriteLine(student);


        }
        private static void NullProvjera(string sadrzaj)
        {
            string sadrazjVelikaSlova1 = sadrzaj ?? "NOT SET";
            string sadrazjVelikaSlova2 = sadrzaj?.ToUpper() ?? "NOT SET";

        }
        private static int Sumiraj(params int [] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }
        private static void DemonstrirajParams()
        {
            Console.WriteLine("Suma -> " + Sumiraj(1,6,9,44,82,66,33));
            Console.WriteLine("Suma -> " + Sumiraj(new int[] { 1, 6, 9, 44, 82, 66, 33 }));
        }
        private static void PozoviDeconstruct()
        {
            Student student = new Student(190000, "Denis", "Music");
            (int indeks, string ime, string prezime) = student;
            
            //int indeks;
            //string ime, prezime;
            //student.Deconstruct(out indeks, out ime, out prezime);
            Console.WriteLine($"{indeks} {ime} {prezime}");

        }
        private static void PripremiStudentaRef(ref Student student)
        {
            student = new Student(190000, "Denis", "Music");
        }
        private static void PripremiStudentaOut(out Student student)
        {
            student = new Student(190000, "Denis", "Music");
        }
        private static void ProslijedjivanjeParametara()
        {
            Student novi = null;
            Student novi2;
            PripremiStudentaRef(ref novi);
            PripremiStudentaOut(out novi2);
            Console.WriteLine(novi);
            Console.WriteLine(novi2);

        }
        private static void PodrazumijevaneVrijednosti()
        {
            int a = new int();
            decimal d = new decimal();
            Student[] studenti = new Student[5];
            int? PonudaId = null;
        }
        private static void ValueVsReference()
        {
            Student s1 = new Student(150051, "Denis", "Music");
            Student s2 = s1;
            Console.WriteLine(nameof(s1) + " ->" + s1);
            Console.WriteLine(nameof(s2) + " ->" + s2);
            s2.Indeks = 150152;
            Console.WriteLine(nameof(s1) + " ->" + s1);
            Console.WriteLine(nameof(s2) + " ->" + s2);

            Predmet prI = new Predmet() { Semestar = 1, Naziv = "PRI" };
            Predmet prII = prI;
            Console.WriteLine(nameof(prI) + " ->" + prI);
            Console.WriteLine(nameof(prII) + " ->" + prII);
            prII.Naziv = "PRII";
            Console.WriteLine(nameof(prI) + " ->" + prI);
            Console.WriteLine(nameof(prII) + " ->" + prII);


        }
    }
}
