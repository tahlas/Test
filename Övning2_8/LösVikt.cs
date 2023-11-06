using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_8
{
    internal class LösVikt : Vara
    {
        protected double kiloPris;
        protected double vikt;

        public LösVikt(string namn, double kiloPris, double vikt) : base(namn)
        {
            this.kiloPris = kiloPris;
            this.vikt = vikt;
        }

        public double KiloPris
        {
            get { return kiloPris; }
            set { kiloPris = value;}
        }

        public double Vikt
        {
            get { return vikt; }
            set { vikt = value;}    
        }

        public override double BeräknaPris()
        {
            return kiloPris * vikt;
        }

        public override string ToString()
        {
            return base.ToString() + " " + vikt + " kg, " + kiloPris + "kr/kg.\t" + BeräknaPris() + " kr.";  
        }

        public int CompareTo(Vara vara)
        {
            return BeräknaPris().CompareTo(vara.BeräknaPris());
        }


    }
}
