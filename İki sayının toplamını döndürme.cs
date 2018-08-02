using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void toplam(int sayı1, int sayı2) { Console.WriteLine("toplam: " +(sayı1 + sayı2)); }
        static void Main(string[] args)
        {
            Console.WriteLine("İki sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            toplam(a, b);
            Console.ReadLine();
        }
    }
}
