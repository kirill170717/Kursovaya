using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    class SystemExit
    {
        public bool SysEx(int? log = null, int? pass = null, int? las = null, int? fir = null, int? dat = null, int? ag = null, int? gen = null, int? nu = null)
        {
            MessageBox.Show("Пустые поля");
            return true;
        }
    }
}
