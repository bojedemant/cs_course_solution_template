using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
         
        {
            double gns=0;
            int[] løn = { 10000, 20000, 13000, 41000, 30000 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(løn[i]);
                gns = gns + løn[i];

            }
            Console.WriteLine("gennemsnit " +(gns/5).ToString("N2"));
        }
    }
}
