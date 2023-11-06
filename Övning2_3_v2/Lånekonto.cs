using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3_v2
{
    //Inte klar
    internal class Lånekonto : BankKonto
    {
        private double kreditGräns = 0;

        public Lånekonto(string personNummer, double ränteSats, double kreditGräns) : base(personNummer, ränteSats)
        {
            this.kreditGräns = kreditGräns;
        }

        public override bool Uttag(double belopp)
        {
            if(belopp<=behållning + kreditGräns)
            {
                behållning -= belopp;
                return true;
            }
            return false;
        }

        public override double BeräknaRänta()
        {
            double ränta = 0;
            if (behållning < 0)
            {
                
                ränta = behållning * ränteSats / 100;
                behållning += ränta;
            }
            return ränta;
        }

        public override string ToString()
        {
            return "Lånekonto " + base.ToString() + ": " + behållning;
        }

    }
}
