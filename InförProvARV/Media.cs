using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InförProvARV
{
    internal abstract class Media : IComparable<Media>
    {
        protected string titel;
        protected int utgivningsÅr;
        protected int pris;

        public Media(string titel, int utgivningsÅr, int pris)
        {
            this.titel = titel;
            this.utgivningsÅr = utgivningsÅr; 
            this.pris = pris;

        }

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public int UtgivningsÅr
        {
            get { return utgivningsÅr ; }
            set { utgivningsÅr = value; }
        }

        public int Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        public override string ToString()
        {
            return "Titel: " + titel + " | Utgivningsår: " + utgivningsÅr + " | Pris: " + pris;
        }


        public int CompareTo(Media media)
        {
            return pris.CompareTo(media.pris);
        }

    }
}
