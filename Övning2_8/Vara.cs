using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_8
{
    internal abstract class Vara : IComparable<Vara>
    {
        protected string namn;

        public Vara(string namn)
        {
            this.namn = namn;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public abstract double BeräknaPris();

        public override string ToString()
        {
            return namn;
        }

        //Går endast att ha EN CompareTo
        public int CompareTo(Vara vara)
        {
            return BeräknaPris().CompareTo(vara.BeräknaPris());
        }



    }
}
