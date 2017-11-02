using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 11; a++)
            {
                for (int i = 1; i < 11; i++)
                {
                    int b = i * a;

                    if (b >= 50) //styr farve alt efter resultat.
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    if (b < 10)
                         Console.Write("   " + b);
                  
                    else
                    {
                        if (i == 10)
                        {

                            
                                if (b < 100)
                                    Console.WriteLine("  " + b);
                                else
                                    Console.WriteLine(" " + b);

                            
                        }
                        else
                            Console.Write("  " + b);
                    }
                }

            }
        }
    }
}
