using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        { 
            Trekant t1 = new Trekant(10,15);
          //  t1.;

            //t1.Højde = 10;
            Console.WriteLine(t1.Areal);
        }
     }


    public class Trekant
    {
        public int Grundlinie { get; private set; }
        public int Højde { get; private set; }

        public Trekant (int grundlinie, int højde)
        {
            this.Grundlinie = grundlinie;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return this.Grundlinie * this.Højde * 0.5;
            }
        }

    }
}
