using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12_opg1_Delegates
{
    class Program
    {
        //public delegate int BeregnDelegate(int a, int b);  //oprettelse af delegate (mulighed for at kalde ekstern funktion)
        
        static void Main(string[] args)
        {
            int res = Beregner(1, 2, Plus);
            res = Beregner(4, 2, Minus);
            res = Beregner(2, 2, Gange);
            res = Beregner(10, 2, Divider);
            res = Beregner(5, 5, (x, y) => x * y);  //brug af anonym metode  ... metoden (beregningen) er inkluderet i kaldet. gør det samme som de ovenstående. => er lamda operator.
         //   res = Beregner(10, 2, Sivider);
        }

        

        //public static int Beregner(int a, int b, BeregnDelegate funktion)   // opret funktion som kalder fuktioner af den type der er beskrevet i delegatereklæringen. funktionsnavnet overføres ved kald og compiler finde funktion i liste af muligheder
        //udkommenteret ovenfor er 'gammel' metode hører sammen med udkommenteret delegate linie
        public static int Beregner(int a,int b, Func<int ,int, int> funktion) 
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
