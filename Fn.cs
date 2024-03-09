using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarakterDonusum
{
    internal class Fn
    {
        public static void TextBDeg(TextBox T_Acik, TextBox T_Kapali)
        {
            T_Acik.ReadOnly = true;
            T_Kapali.ReadOnly = false;
        }
    }
}
