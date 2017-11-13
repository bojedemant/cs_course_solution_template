using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_opg2_terning_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            
        }

    }


    class Terning
    {
        public int Værdi;
        private bool Snyd;
        private static Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine(Værdi);
        }

        public void Ryst()
        {

            if (Snyd == false)
            {
                Værdi = rnd.Next(1, 7);
            }
            else if (Snyd == true)
            {
                Værdi = 6;
            }
        }

        //default constructor
        public Terning()
        {
            Værdi = 1;
            Snyd = false;

        }

        //custom constructor
        public Terning (bool snyd)
        {
            Værdi = 1;
            Snyd = snyd;
        }


    }

}
