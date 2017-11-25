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
        }
    }
}

public class Terning
{
    private int værdi;

    private static Random rnd = new Random();


    
    public int Værdi
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