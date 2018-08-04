using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static int[] İnteDön(string metin)
        {
            return Array.ConvertAll(metin.Split(' '), i => int.Parse(i));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("iki karmaşık sayı giriniz: ");
            string a = Console.ReadLine();
            int[] aSayı = İnteDön(a);

            string b = Console.ReadLine();
            int[] bSayı = İnteDön(b);

            Console.WriteLine((aSayı[0]+bSayı[0])+"+"+(aSayı[1]+bSayı[1])+"i");
            Console.ReadLine();
            
        }
    }
}
