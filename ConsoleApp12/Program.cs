using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }
        }
    }

    public class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("jeg er et dyr og heddder " + Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }
    
    public class Hund : Dyr
    {

        public override void SigNoget()
        {
            Console.WriteLine("jeg er en hund og hedder " + Navn);
        }

    }

    public class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("jeg er en kat og hedder " + Navn);
        }

    }
}


