using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_3
{
    internal class Bank
    {
        //BankKonto konto;
        //public BankKonto[] konton;
        public List<BankKonto> Konton = new List<BankKonto>();

        //egenskap
        public double Behållning
        {
            get
            {
                double behållning = 0;

                foreach(BankKonto konto in Konton)
                {
                    behållning += konto.Behållning;
                }
                return behållning;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
