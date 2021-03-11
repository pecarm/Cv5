using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv5
{
    class Nakladni : Auto
    {
        private double prepravovano;
        private double max;

        public double PrepravovanyNaklad
        {
            get { return prepravovano; }
            set
            {
                if (PrepravovanyNaklad + value > MaxNaklad)
                {
                    throw new Exception("Auto by bylo pretizene!");
                }
                prepravovano = value; }
        }

        public double MaxNaklad
        {
            get { return max; }
            private set { max = value; }
        }

        public Nakladni(TypPaliva palivo, double velikostNadrze, double stavNadrze, double maxNaklad, double prepravovanyNaklad)
        {
            Palivo = palivo;
            VelikostNadrze = velikostNadrze;
            StavNadrze = 0;
            Natankuj(palivo, stavNadrze);
            MaxNaklad = maxNaklad;
            PrepravovanyNaklad = prepravovanyNaklad;
        }

        public override string ToString()
        {
            return "Palivo " + Palivo + ", maximalni naklad: " + MaxNaklad + ", prepravovany naklad: " + PrepravovanyNaklad + ", objem nadrze: " + VelikostNadrze + ", stav nadrze: " + StavNadrze;
        }
    }
}