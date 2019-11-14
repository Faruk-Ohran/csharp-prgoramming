using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    class Validator
    {
        public const string porObaveznaVrijednost = "Obavezna vrijednost!";

        public static bool ObaveznoPolje(TextBox textBox, ErrorProvider err, string poruka)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
