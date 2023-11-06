using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3_v2
{
    internal class Bank
    {
        public List<BankKonto> Konton = new List<BankKonto>();

        public double Behållning
        {
            get
            {
                double behållning = 0;
                foreach(BankKonto konto in Konton)
                {
                    behållning+=konto.Behållning;
                }
                return behållning;
            }
        }
    }
}
