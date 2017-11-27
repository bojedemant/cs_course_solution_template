using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_opg_2_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);

            }
        }
    }

    class Hund : ICompareable
    {
        public string Navn { get; set; }
            
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund hund = obj as Hund; ???
            if (this Hund < hund.Hund)
        }
    }

}
