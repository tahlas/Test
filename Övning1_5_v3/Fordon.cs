using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1_5_v3
{
    internal class Fordon
    {
        public enum Typ { Bil, MC}; 
        string regNr;
        string märke;
        string modell;
        Typ fordonsTyp;
        

        public Fordon(string regNr, string märke, string modell, Typ fordonsTyp)
        {
            this.regNr = regNr;
            this.märke = märke;
            this.modell = modell;
            this.fordonsTyp = fordonsTyp;
        }
        public string RegNr
        {
            get { return regNr; }
            set { regNr = value; }
        }

        public string Märke
        {
            get { return märke; }
            set { märke = value; }
        }

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        public Typ FordonsTyp
        {
            get { return fordonsTyp; }
            set { fordonsTyp = value; }
            
        }


        

        public static string GodkännRegNr(string regNr)
        {
            if (regNr.Length != 6)              //om längden inte är 6
                throw new FelFormatException();            
            for(int i = 0; i<3; i++)             
            {
                if (!char.IsLetter(regNr[i]))   //om tre första char inte är bokstäver
                    throw new FelFormatException();
            }
            for(int i = 3; i<6; i++)              
            {
                if (!char.IsDigit(regNr[i]))    //om tre sista char inte är siffror
                {
                    throw new FelFormatException();
                }
            }

            return regNr.ToUpper();             //om det är på rätt format, returnerar regNr och omvandlar små bokstäver till stora
        }

        public override string ToString()
        {
            return fordonsTyp + ": " + märke + " " + modell + " (" + regNr + ")"; //Ex: Bil: Volvo V70 (ABC123)
        }


    }
}
