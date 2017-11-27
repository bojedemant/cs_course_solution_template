namespace Module10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Tandbørste T = new Tandbørste();

            Lastbil l = new Lastbil();

            IMaskine m = new Tandbørste;


            Imaskine[] maskiner = new Imaskine[2];
            maskiner[0] = new Tandbørste();
            maskiner[1] = new Lastbil();




            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

    
    }

 
}


interface IDatabaseFunktioner{
     void gem();

 }



interface Imaskine, IDatabaseFunktioner{  //interface beskriver metoder der SKAL være tilstede på alle klasser der bruger Imaskine
    void Start();

    void Stop();

    int Status(bool v);
}


class Tandbørste : IMaskine{
    public void Start(){}
    public void Stop(){}
    public int Status(bool v){
        return 0;
    }
}

class Lastbil : IMaskine{
    public void Start(){}
    public void Stop(){}
    public int Status(bool v){
        return 0;
    }

}

class FakturaPrinter: IMaskine{
    public void Start(){}
    public void Stop(){}
    public int Status(bool v){
        return 0;
    }
}