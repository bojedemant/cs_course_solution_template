using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;  //pointer
            p1 = new Person(); //opret

            Person p2;
            p2 = new Person();

            Person p3;
            p3 = new Person("Boje", "Demant", 1961);


            p1.Fornavn = "Boje";
            p1.Efternavn = "Demant";
            p1.Fødselsår = 1961;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());



        }



        



        public class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;

            public string FuldtNavn()
            {
                return $"{Fornavn}{Efternavn}";
            }

            public int EstimeretAlder()
            {
                int år = DateTime.Now.Year;
                return år - this.Fødselsår;
            }

            //default constructor
            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }

            public Person(string fornavn, string efternavn, int fødselsår)
            {
                this.Fornavn = fornavn.ToUpper();
                this.Efternavn = efternavn.ToUpper();
                this.Fødselsår = fødselsår;
            }

        }
    }
}
