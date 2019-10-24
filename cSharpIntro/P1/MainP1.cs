using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P1
{
    public class MainP1
    {
        static void ProvjeriTip(object obj)
        {
            if (obj is int)
                Console.WriteLine("Int");
            else if (obj is Student)
                Console.WriteLine("Student");
        }
        public static void Run()
        {
            object[] studenti = new Student[10];
            for (int i = 0; i < studenti.Length; i++)
                studenti[i] = new Student(190000 + i, $"Ime {i}", $"Prezime {i}");
            for (int i = 0; i < studenti.Length; i++) {
                ProvjeriTip(studenti[i]);
                Console.WriteLine(studenti[i]);
            }
        }

    }
}
