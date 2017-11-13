using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //skab variabel der kan pege på en person
            Person p;
            
            //skab en person og bind ref til p    
            p = new Person(); //opret object

            Person p2 = new Person();
            p2.name = "Boje";

            string t = p.ToString(); //konverter object til streng
            Console.WriteLine(t);

            bil b = new Bil;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        

        //alle kan få reference til Person
        public class Person
        {
            public string name;
            public int age;
            private string gender;



        //Constructor
        public Person()
            {
                Console.WriteLine();
                //initialisering af felter
                name = "";
                age = 0;


            }

            //custom constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }


            //custom constructor
            public Person(string name)
            {
                this.name = name;
            }

            //Destructor køres når scope lukkes
            ~Person()
            {
                //rydde op - lukke
            }

        }

        //dette object kan der kun refereres til i dette project
        internal class Bil
        {

        }
    }
}
