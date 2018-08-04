using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("iki tane karmaşık sayı giriniz: ");
            Console.Write("gerçek kısmı: "); int a = int.Parse(Console.ReadLine());
            Console.Write("sanal kısmı: "); int b = int.Parse(Console.ReadLine());
            Console.Write("gerçek kısmı: "); int c = int.Parse(Console.ReadLine());
            Console.Write("sanal kısmı: "); int d = int.Parse(Console.ReadLine());

            Console.WriteLine(a+"+"+b+"i");
            Console.WriteLine(c+"+"+d+"i");


            Console.WriteLine("toplamı= "+(a+c)+"+"+(b+d)+"i");
            Console.ReadLine();
        }

    }
}
