using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Övning2_4
{
    //Basklass
    internal abstract class Figur
    {
        protected int bredd;
        protected int höjd;

        public Figur(int bredd, int höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }
        //Behöver inte egenskaper


        public override string ToString()
        {
            return bredd + "x" + höjd;
        }

    }

    internal class Triangel : Figur,IArea
    {
        public Triangel(int bredd, int höjd) : base(bredd, höjd)
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
        public Cirkel(int bredd):base(bredd, bredd)
        {

        }
        public double Area()
        {
            return bredd * bredd * Math.PI; //r*r*pi
        }

        public override string ToString()
        {
            return "Cirkel: " + base.ToString();
        }

    }
    internal class Linje : Figur
    {
        public Linje(int bredd, int höjd) : base(bredd, höjd)
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
