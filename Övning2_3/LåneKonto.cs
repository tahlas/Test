using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3
{
    internal class LåneKonto : BankKonto
    {
        double kreditGräns;


        public LåneKonto(string personNr, double ränteSats, double kreditGräns) : base(personNr, ränteSats)
        {
            this.kreditGräns = kreditGräns;
        }

        public double KreditGräns
        {
            get { return kreditGräns; }
            set { kreditGräns = value; }
        }

        public override bool Uttag(double belopp)
        {
            if(belopp>kreditGräns)
            {
                return false;
            }

            return true;
        }
        public override double BeräknaRänta()
        {
            double ränta = 0;
            if(behållning < 0)
            {
                ränta = behållning * ränteSats / 100;
                behållning += ränta;
            }
            return ränta;
            
        }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}
