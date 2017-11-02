using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int heltal=10;
            double kommatal=12.5;
            
            
            System.Console.WriteLine(heltal);
            heltal++;
            System.Console.WriteLine(heltal);
            heltal--;
            System.Console.WriteLine(heltal);
            heltal += 20;
            System.Console.WriteLine(heltal);

            System.Console.WriteLine(kommatal);
            kommatal++;
            System.Console.WriteLine(kommatal);
            kommatal--;                                
            System.Console.WriteLine(kommatal);
            kommatal *= 2;                          //gang tal med 2
            System.Console.WriteLine(kommatal);

            FilType ft = FilType.csv;  //se de erklærede filtyper i filtype.cs fil
            System.Console.WriteLine(ft);
            System.Console.WriteLine((int)ft);

            DateTime d1 = DateTime.Now; //se den erklærede struct i person.cs fil
            System.Console.WriteLine(d1);
            System.Console.WriteLine(d1.ToString("dd-MM-yyyy"));

            Person p;
            p.Ld = 1;
            p.Navn = "Boje";

            System.Console.WriteLine(p.Navn);







        }
    }

}
