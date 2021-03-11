using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobni osobni = new Osobni(Auto.TypPaliva.Benzin, 40, 20, 5, 1);
            Nakladni nakladni = new Nakladni(Auto.TypPaliva.Nafta, 80, 40, 1800, 300);
            Console.WriteLine(osobni.ToString());
            Console.WriteLine(nakladni.ToString());
            try
            {
                //v pripade potreby si zmente hodnoty v provolani, aby nebyly vyvolany vyjimky
                osobni.Natankuj(Auto.TypPaliva.Benzin, 10);
                nakladni.NastavPredvolbuRadia(3, 93.6);
                osobni.PrepravovaneOsoby = 2;
                nakladni.PreladRadioNaPredvolbu(2);
                nakladni.ZapniRadio(true);
                Console.WriteLine(osobni.ToString());
                Console.WriteLine(nakladni.ToString());
                Console.WriteLine(nakladni.Radio.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
            }
        }
    }
}