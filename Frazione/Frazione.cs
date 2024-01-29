using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }
        public Frazione(int num, int denomin) 
        {
            Numeratore = num;
            Denominatore = denomin;
            Semplificatore(ref num, ref denomin);
        }
        private static int MCD(int a, int b)
        {
            int r; 
            while (b != 0) 
            {
                r = a % b; 
                a = b; 
                b = r; 
            }
            return a;
        }

        public static void Semplificatore(ref int num, ref int denomin)
        {
            int divisore = MCD(num, denomin);
            num = num / divisore;
            denomin = denomin / divisore;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numeratore, Denominatore);
        }

        public static Frazione Parse(string fraz)
        {
            string[] termini = fraz.Split('/');
            Frazione f = new Frazione(int.Parse(termini[0]), int.Parse(termini[1]));
            return f;
        }
    }
}
