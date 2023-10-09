using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning1_5_v3
{
    internal class FelFormatException : Exception
    {
        string message = "Registreringsnummer måste vara på formen ABC123";

        public override string ToString()
        {
            return message;
        }
    }
}
