using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3
{
    internal class SparKonto : BankKonto
    { 
        public SparKonto(string personNr, double ränteSats) : base(personNr, ränteSats)
        {
        }

        //metoder
        public override bool Uttag(double belopp)
        {
            if(belopp<=behållning)
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
    }
}
