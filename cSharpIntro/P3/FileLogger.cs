using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpIntro.P3
{
    class FileLogger : ILogger
    {
        public string PutanjaDoFajla { get; set; }
        public FileLogger()
        {
            //fajl P3Log.txt ce se nalaziti u istom folderu kao i .exe fajl, a mozete dodati i punu putanju do fajla
            PutanjaDoFajla = "P3Log.txt";
        }
        public void Log(object obj)
        {
            using (StreamWriter sw = new StreamWriter(PutanjaDoFajla, true))
            {
                if (obj is Exception)
                {
                    Exception ex = obj as Exception;
                    sw.WriteLine(ex.Message);
                }
            }
            using (DBLogger db = new DBLogger())
            {

            }
        }
    }
}
