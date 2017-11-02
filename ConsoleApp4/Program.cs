using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Boje";
            string s2 = "Demant";
            string samletNavn = s1 + " " + s2;
            string navnStort = s1.ToUpper() + " " + s2.ToUpper();
            string navnLille = s1.ToLower() + " " + s2.ToLower();
            string del = samletNavn.Substring(5, 6);
            
            Console.WriteLine(samletNavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(del);
            string[] navne = samletNavn.Split(' ');
            for (int i = 0; i < navne.Length; i++)
                Console.WriteLine(navne[i]);
            string filePath = @"x:demo.txt";
            System.IO.File.AppendAllText(filePath, samletNavn);
        }
    }
}
