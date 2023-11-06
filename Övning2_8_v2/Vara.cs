using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2_8_v2
{
    internal abstract class Vara : IComparable<Vara>
    {
        /// <summary>
        /// Namn för varan.
        /// </summary>
        protected string namn;
        /// <summary>
        /// Skapar en ny vara med det angivna namnet.
        /// </summary>
        /// <param name="namn">Namnet på varan.</param>
        public Vara(string namn)
        {
            this.namn = namn;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        /// <summary>
        /// Beräknar priset genom att multiplicera "pris" och "mängd"
        /// </summary>
        /// <returns></returns>
        public abstract double BeräknaPris();


        public override string ToString()
        {
            return namn;
        }
        /// <summary>
        /// Sorterar priserna från minst till störst.
        /// </summary>
        /// <param name="vara"></param>
        /// <returns></returns>
        public int CompareTo(Vara vara)
        {
            return BeräknaPris().CompareTo(vara.BeräknaPris());
        }
    }

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
            set { kiloPris = value; }
        }
        public double Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }

        public override double BeräknaPris()
        {
            return kiloPris * vikt; // kr/kg * kg = kr
        }
        /// <summary>
        /// Skrivet ut namnet för varan, vikten, kilopriset och priset.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} {vikt} kg, {kiloPris} kr/kg. Pris: {BeräknaPris()}";
        }
    }

    internal class StyckSak : Vara
    {
        protected double styckPris;
        protected int antal;
        public StyckSak(string namn, double styckPris, int antal) : base(namn)
        {
            this.styckPris = styckPris;
            this.antal = antal;
        }
        public int Antal
        {
            get { return antal; }
            set { antal = value; }
        }

        public double StyckPris
        {
            get { return styckPris; }
            set { styckPris = value; }
        }
        //public int MyProperty { get; protected set; }

        public override double BeräknaPris()
        {
            return styckPris * antal; // kr/st * st = st
        }
        /// <summary>
        /// Skrivet ut namnet för varan, antalet, styckpriset och priset.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} {antal} st, {styckPris} kr/st. Pris: {BeräknaPris()}";
        }

    }
}

