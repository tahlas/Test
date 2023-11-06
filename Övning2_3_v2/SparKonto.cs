using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3_v2
{
    internal class SparKonto : BankKonto
    {
        public SparKonto(string personNr, double ränteSats) : base(personNr, ränteSats)
        {
            //behöver jag något här?
        }

        public override bool Uttag(double belopp)
        {
            if (belopp <= behållning)
            {
                behållning -= belopp;
                return true;
            }
            return false;
        }

        public override double BeräknaRänta()
        {
            double ränta = behållning * ränteSats / 100;
            behållning += ränta;
            return ränta;
        }

        public override string ToString()
        {
            return "Sparkonto " + base.ToString() + ": " + behållning;
        }
    }
}
