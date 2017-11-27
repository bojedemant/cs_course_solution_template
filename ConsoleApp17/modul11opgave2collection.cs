using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class modul11opgave2collection
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kort
    {

        public string Kulør { get; set; }
        public int Værdi { set; get; }

        public override string ToString()
        {
            return this.Kulør + "" + this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();


        public void TilføjKort(Kort K)
        {
            bunke.Push(K);
        }

        public FjernKort(void)
        {
            if (bunke.Count>0)
                return bunke.Pop();
            return null;
        }

        public void vis()
        {
            foreach (var item in bunke)
            {

            }
        }
    }
}
