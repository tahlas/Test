using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InförProvARV
{
    internal class Bok : Media
    {
        protected int sidor;
        protected string författare;

        public Bok(string titel, int utgivningsÅr, int pris, int sidor, string författare) : base (titel, utgivningsÅr, pris)
        {
            this.sidor = sidor;
            this.författare = författare;
        }

        public int Sidor
        {
            get { return sidor; }
            set { sidor = value; }
        }

        public string Författare
        {
            get { return författare; }
            set { författare = value;}
        }

        public override string ToString()
        {
            return "Typ: Bok | " + base.ToString() + " | Sidor: " + sidor + " | Författare: " + författare;  
        }
    }
}
