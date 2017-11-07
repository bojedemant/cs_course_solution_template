using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_opg1_metoder
{
    class Program
    {
         static void Main(string[] args)
         {
             int res = LægSammen(5, 2);
             Console.WriteLine(res);

             double res2 = BeregnAreal(5);
             Console.WriteLine(res2);

            Udskriv();
            Udskriv("hej");
            double res3;
            res3 = BeregnMoms(10000,0.35);
            Console.WriteLine(res3);
            res3 = BeregnMoms(1000);
            Console.WriteLine(res3);

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);

            Udskriv();
            

        }

        static int LægSammen(int a, int b)
         {
             return a + b;
         }
 
         static double BeregnAreal(int radius)
         {
            double pi = System.Math.PI;
            return radius*radius*pi;
         }
 
         static void Udskriv(string text)
         {
           
                Console.WriteLine(text);

         }

        static void Udskriv()
        {
            Console.WriteLine();
        }
 
         static double BeregnMoms(double beløb, double momsPct)
         {
            return beløb * momsPct ;
         }

        static double BeregnMoms(double beløb)
        {
            return beløb * 0.25;
        }
         
         static double Gennemsnit(int[] månedsløn){
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];

            }
            return sum / månedsløn.Length;


         }
    }
}
