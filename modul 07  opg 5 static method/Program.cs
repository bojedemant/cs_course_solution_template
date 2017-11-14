using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_07__opg_5_static_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));



        }
    }
}


class ArealBeregninger
{
    public static double  BeregnArealFirkant(double højde, double bredde)
    {
        return højde * bredde;
    }

    public static double BeregnArealCirkel(double radius)
    {
        return radius * radius * Math.PI;
    }
}