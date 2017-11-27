using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() { Id = 1, Navn = "Navn1"});
            personer.Add(new Person() { Id = 2, Navn = "Navn2"});
            personer.Add(new Person() { Id = 3, Navn = "Navn3"});
            foreach (var item in personer)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> personer2 = new Dictionary<int, Person>();
            personer2.Add(1, new Person() { Id = 1, Navn = "Navn4" });
            personer2.Add(2, new Person() { Id = 1, Navn = "Navn5" });
            personer2.Add(3, new Person() { Id = 1, Navn = "Navn6" });
            var p = personer2[2];
            Console.WriteLine(p.Navn);
            
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn  { get; set; }
    }
}
