using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cSharpIntro.P3
{
    interface ILogger
    {
        void Log(object obj);
    }
    class FileLogger : ILogger
    {
        public string PutanjaDoFajla { get; set; }
        public FileLogger()
        {
            PutanjaDoFajla = @"C:\Users\online\Desktop\PRIII\cSharpIntro\P3\P3Log.txt";
        }
        public void Log(object obj)
        {
            using (StreamWriter sw = new StreamWriter(PutanjaDoFajla)) { 
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
    class DBLogger : ILogger, IDisposable
    {
        public DBKonekcija db { get; set; }
        public DBLogger()
        {
            db = new DBKonekcija();
        }
        public void Log(object obj)
        {
            db.SpasiUBazu(obj);
        }

        public void Dispose()
        {
            
        }
    }
    class DBKonekcija
    {
        public void SpasiUBazu(object obj) { }
    }
}
