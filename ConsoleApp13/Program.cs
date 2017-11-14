using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fejl opstået: " +ex.Message);
            }
        }
        private static void Run()
        {
            Console.WriteLine("indtast et tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);

        }
    }
}

    
