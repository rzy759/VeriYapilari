using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void ÜsAl(int sayi1, int sayi2) { Console.WriteLine("üssü: " + Math.Pow(sayi1, sayi2)); } 
        static void Main(string[] args)
        {
            Console.WriteLine("iki sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ÜsAl(a, b);
            Console.ReadLine();
        }
    }
}
