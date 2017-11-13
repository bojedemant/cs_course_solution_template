using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_opg3_beregn_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);
            Console.WriteLine(res.arrayGennemsnit);
            Console.WriteLine(res.arraySum);

        }

         static ArrayResultat BeregnOgSorterArray(int[] a)
        {
            ArrayResultat r; //opret pointer til array
            r.arraySum = 0;

            foreach ( var item in a)
            {
                r.arraySum += item;
            }
            r.arrayGennemsnit = r.arraySum / a.Length;
            Array.Sort(a);
            return r;  //returner pointer til array med resultater
        }

        struct ArrayResultat
        {
            public double arraySum;
            public double arrayGennemsnit;
        }
    }
}
