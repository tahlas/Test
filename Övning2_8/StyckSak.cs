using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_8
{
    internal class StyckSak : Vara
    {
        protected double styckPris;
        protected int antal;

        public StyckSak(string namn, double styckPris, int antal) : base(namn)
        {
            this.styckPris = styckPris;
            this.antal = antal;
        }

        public override double BeräknaPris()
        {
            return antal * styckPris;
        }

        public override string ToString()
        {
            return base.ToString() + " " + antal + " st, " + styckPris + "kr/st.\t" + BeräknaPris() + " kr.";
        }
    }
}
