using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InförProvARV
{
    internal class CD : Media
    {
        //byt min till längd?
        protected int längd;
        protected string artist;
        protected int antalLåtar;

        public CD(string titel, int utgivningsÅr, int pris, int längd, string artist, int antalLåtar) : base(titel, utgivningsÅr, pris)
        {
            this.längd = längd;
            this.artist = artist;
            this.antalLåtar = antalLåtar;
        }

        public int Längd
        {
            get { return längd; }
            set { längd = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public int AntalLåtar
        {
            get { return antalLåtar; }
            set { antalLåtar = value;}
        }

        public override string ToString()
        {
            return "Typ: CD | " + base.ToString() + " | Längd (min): " + längd + " | Artist: " + artist + " | Antal låtar: " + antalLåtar;
        }

    }
}
