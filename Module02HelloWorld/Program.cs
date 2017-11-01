using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string indStreng;
            Console.WriteLine("indtast et navn");
            indStreng = Console.ReadLine();                 //læs fra keyboard
            indStreng = indStreng.ToUpper();
            Console.WriteLine("Velkommen "+indStreng);
            Console.ReadKey();
        }
    }
}
