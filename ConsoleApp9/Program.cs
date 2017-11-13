using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "vare 1";
            v1.Pris = 2.25;
            Console.WriteLine(v1.PrisMedMoms());
            Vare v2 = new Vare("vare 2", 100);
            Console.WriteLine(v2.PrisMedMoms());
        }
    }

    public class Vare
    {
        
        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this.Navn = Navn;
            this.Pris = pris;
        }

        private string navn;
        public string Navn
        {
            get {
                return navn;
            }
            set {
                navn = value;
            }
        }

        private double pris;
        public double Pris
        {
            get {
                return pris;
            }
            set {
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }
    }
}