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

            Console.WriteLine(Trekant.Areal(10,15));
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
