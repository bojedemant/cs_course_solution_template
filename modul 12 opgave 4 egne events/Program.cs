using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_12_opgave_4_egne_events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { Kreditmax = -500 };
            k.KreditOverskredet += (s, e) =>
            {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(600);
        }
    }

    public class Kunde
    {
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int Kreditmax { get; set; }
        public void Køb(int værdi) {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < Kreditmax)
            {
                if (KreditOverskredet != null)
                    KreditOverskredet(this, new EventArgs());
            }

        }
    
    }

}
