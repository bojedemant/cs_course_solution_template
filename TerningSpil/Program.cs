using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningSpil
{
    class Program
    {
        static void Main(string[] args)
        {

            LudoTerning L = new LudoTerning();  //opret pointer, L, til objekt Ludoterning og opret objekt. Slå med ludo terning og gem værdi i objekt
            L.Skriv();                          //udskriv værdi af ludoterning ... data og object forsvinder når der ikke refereres til l mere.

            Terning[] terninger = new Terning[4];
            terninger[0] = new Terning();
            terninger[1] = new LudoTerning();
            terninger[2] = new LudoTerning();
            terninger[3] = new Terning();

            foreach (var item in terninger)
            {
                item.Skriv();
            }

            Terning K = new Terning(100);  //test at validering < 1 og >6 virker
            K.Skriv();


        }
    }
}

public class Terning
{
    private int værdi;  //der oprettes en værdi der kun kan tilgås i denne class

    private static Random rnd = new Random();  // der oprettes en statisk random funktion der kun kan tilgås af denne class


    
    public int Værdi                   // Metode der sætter værdi til 1 hvis værdien er <1 eller >6 ved kald. Returnerer værdi ved 
    {
        get{
            return this.værdi;
        }
        set{
            if (value < 1 || value > 6)
                value = 1;
            this.værdi = value;
        }
    }

    public int Ryst()
    {
        this.Værdi = rnd.Next(1, 7);
        return værdi;
    }

    public virtual void Skriv()
    {
        Console.WriteLine("[" + this.Værdi + "]");
    }

    public Terning()
    {
        this.Ryst();
    }

    public Terning(int værdi)
    {
        this.Værdi = værdi;
    }
}

public class LudoTerning : Terning
{

    public bool ErGlobus()
    {
        return this.Værdi == 3;
    }

    public bool ErStjerne()
    {
        return this.Værdi == 5;
    }

    public LudoTerning() : base()
    {

    }
 
    public LudoTerning(int Værdi) : base(Værdi)
    {

    }

    public override void Skriv()
    {

        if (this.Værdi == 3)
            Console.WriteLine("[G]");
        else if (this.Værdi == 5)
            Console.WriteLine("[S]");
        else
            base.Skriv();

       

    }

}

