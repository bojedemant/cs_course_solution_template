using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = Beregn(1, 2);
            Console.WriteLine(res1);
            int res2 = Beregn(1, 2, 3);
            Console.WriteLine(res2);
            int res3 = Beregn(1, 2, 3, 4);
            Console.WriteLine(res3);
        }

        /*
                public static int Beregn(int v1, int v2)
                {
                    return v1 + v2;
                }

                public static int Beregn(int v1, int v2, int v3)
                {
                    return v1 + v2 + v3;
                }

                public static int Beregn(int v1, int v2, int v3, int v4)
                {
                    return v1 + v2 + v3 + v4;
                }
        */

        public static int Beregn(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Beregn(int v1, int v2, int v3)
        {

            return Beregn(v1, v2) + v3;
        }

        public static int Beregn(int v1, int v2, int v3, int v4)
        {
            return Beregn(v1, v2, v3) + v4;
        }


    }

}
