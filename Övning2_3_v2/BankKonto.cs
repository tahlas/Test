using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3_v2
{
    internal abstract class BankKonto
    {
        protected string personNummer;
        protected double behållning = 0;
        protected double ränteSats;
        
        public BankKonto(string personNummer, double ränteSats)
        {
            this.personNummer = personNummer;
            
            this.ränteSats = ränteSats;
        }

        public string PersonNummer
        {
            get { return personNummer; }
            set { personNummer = value; }
        }
        public double Behållning
        {
            get { return behållning; }
            set { behållning = value; }
        }

        public double RänteSats
        {
            get { return ränteSats; }
            set { ränteSats = value; }
        }

        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public abstract bool Uttag(double belopp);
        public abstract double BeräknaRänta();
        public override string ToString()
        {
            return personNummer;
        }
    }
}
