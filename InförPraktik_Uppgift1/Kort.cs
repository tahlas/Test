using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InförPraktik_Uppgift1
{
    internal class Kort
    {
        string färg;
        string valör;

        public Kort(string färg, string valör)
        {
            this.färg = färg;
            this.valör = valör;
        }
        public string Färg
        {
            get { return färg; }
            set { färg = value;}
        }
        public string Valör
        {
            get { return valör; }
            set { valör = value; }
        }

        public override string ToString()
        {
            return färg + " " + valör;
        }
    }
}
