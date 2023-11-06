using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3
{
    internal abstract class BankKonto 
    {
        //Medlemsdata
        protected string personNr;
        protected double behållning = 0;
        protected double ränteSats;


        //Konstruktor
        public BankKonto(string personNr, double ränteSats)
        {
            this.personNr = personNr;
            this.ränteSats = ränteSats;
        }

        //Egenskaper
        public double Behållning
        {
            get { return behållning; }
            set { behållning = value; }
        }

        //Metoder
        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public abstract bool Uttag(double belopp);

        public abstract double BeräknaRänta();

        //public override string ToString()
        //{
        //    return base.ToString();
        //}



    }
}
