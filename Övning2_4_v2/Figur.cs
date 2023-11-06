using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_4_v2
{
    internal abstract class Figur 
    {
        protected double bredd;

        protected double höjd;

        public Figur(double bredd, double höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }

        //Behöver inga egenskaper


        public override string ToString()
        {
            return bredd + "x" + höjd;
        }
    }

    internal class Triangel : Figur, IArea
    {
        public Triangel(double bredd, double höjd   ) : base(bredd, höjd) 
        {   
        }

        public double Area()
        {
            return bredd * höjd / 2.0;
        }

        public override string ToString()
        {
            return "Triangel: " + base.ToString();
        }

    }

    internal class Cirkel : Figur, IArea
    {
        public Cirkel(double bredd, double höjd) : base(bredd, höjd)
        {
        }

        public double Area()
        {
            return Math.PI * (bredd / 2) * (bredd / 2); //bredd=diameter
        }

        public override string ToString()
        {
            return "Cirkel: " + base.ToString();
        }
    }

    internal class Linje : Figur
    {
        public Linje(double bredd, double höjd) : base(bredd, höjd)
        {

        }

        public override string ToString()
        {
            return "Linje: " + base.ToString();
        }
    }

    public interface IArea
    {
        double Area();
    }
}
