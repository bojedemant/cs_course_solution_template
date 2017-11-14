using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person = new Person();
            person.Fornavn = "boje";
            person.Efternavn = "demant";
            Console.WriteLine(person.FuldtNavn());

            Elev elev;
            elev = new Elev() { Fornavn="Kirstine", Efternavn="Demant",Klasselokale="27"};
            //elev.Fornavn = "Kirstine";
            //elev.Efternavn = "demant";
            //elev.Klasselokale = "27";
            Console.WriteLine(elev.FuldtNavn());

            Instruktør instruktør;
            instruktør = new Instruktør();
            instruktør.Fornavn = "Dyveke";
            instruktør.Efternavn = "demant";
            instruktør.NøgleID = "55";
            Console.WriteLine(instruktør.FuldtNavn());



        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + Efternavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

    }

    class Instruktør : Person
    {
        public string NøgleID{ get; set; }
    }
}
