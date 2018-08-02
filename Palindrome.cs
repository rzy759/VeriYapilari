using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz: ");
            string sayı = Console.ReadLine();
            
            char[]sayı1=sayı.ToCharArray();
            Array.Reverse(sayı1);

            string tekrar = new string(sayı1);

            int a = int.Parse(sayı);
            int b = int.Parse(tekrar);

            if (sayı == tekrar) Console.WriteLine("bu sayı bir palindrome sayıdır ");
            else Console.WriteLine("bu sayı bir palindrome sayı değildir ");

            Console.ReadLine();
        }
    }
}
