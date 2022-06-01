using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class DivisionMachine
    {
        public int Dividir(NumberModel modelo)
        {
            return modelo.NumberA / modelo.NumberB;
        }
    }
}
