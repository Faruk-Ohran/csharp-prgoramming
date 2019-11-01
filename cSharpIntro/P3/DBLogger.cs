using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpIntro.P3
{
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
}
