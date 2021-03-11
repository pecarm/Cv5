using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv5
{
    sealed class Autoradio
    {
        #region Attributes
        private double kmitocet;
        private bool zapnuto;
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();

        public double NaladenyKmitocet
        {
            get { return kmitocet; }
            set { kmitocet = value; }
        }

        public bool RadioZapnuto
        {
            get { return zapnuto; }
            set { zapnuto = value; }
        }
        #endregion

        #region Constructor
        public Autoradio()
        {
            kmitocet = 0;
            zapnuto = false;
        }
        #endregion

        #region Methods
        public void NastavPredvolbu(int cislo, double kmitocet)
        {
            if(predvolby.ContainsKey(cislo))
            {
                predvolby.Remove(cislo);
            }
            predvolby.Add(cislo, kmitocet);
        }

        public void PreladNaPredvolbu(int cislo)
        {
            if (RadioZapnuto == false)
            {
                throw new Exception("Radio neni zapnuto!");
            }

            if (predvolby.TryGetValue(cislo, out double value))
            {
                NaladenyKmitocet = value;
            }
            else throw new Exception("Tato predvolba neni nastavena!");
        }

        public override string ToString()
        {
            string cislaPredvoleb = "";

            if (this.predvolby.Count > 0)
            {
                int[] polePredvoleb = this.predvolby.Select(cislo => cislo.Key).ToArray();
                foreach (int prvek in polePredvoleb)
                {
                    cislaPredvoleb += (prvek + " ");
                }
            }
            
            return "Zapnuto: " + RadioZapnuto + ", aktualni kmitocet: " + NaladenyKmitocet + ", pocet predvoleb: " + this.predvolby.Count + ", cisla predvoleb: " + cislaPredvoleb;
        }
        #endregion
    }
}
