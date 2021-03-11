using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv5
{
    class Osobni : Auto
    {
        #region Attributes
        private int prepravovano;
        private int max;

        public int PrepravovaneOsoby
        {
            get { return prepravovano; }
            set
            {
                if (PrepravovaneOsoby + value > MaxOsob)
                {
                    throw new Exception("Prilis mnoho osob!");
                }
                prepravovano = value;
            }
        }

        public int MaxOsob
        {
            get { return max; }
            private set { max = value; }
        }
        #endregion

        #region Constructor
        public Osobni(TypPaliva palivo, double velikostNadrze, double stavNadrze, int maxOsob, int prepravovaneOsoby)
        {
            Palivo = palivo;
            VelikostNadrze = velikostNadrze;
            StavNadrze = 0;
            Natankuj(palivo, stavNadrze);
            MaxOsob = maxOsob;
            PrepravovaneOsoby = prepravovaneOsoby;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Palivo " + Palivo + ", maximalni pocet osob: " + MaxOsob + ", prepravovanych osob: " + PrepravovaneOsoby + ", objem nadrze: " + VelikostNadrze + ", stav nadrze: " + StavNadrze;
        }
        #endregion
    }
}