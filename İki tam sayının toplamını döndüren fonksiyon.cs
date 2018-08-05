using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {    
        static int toplam(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {           
            Console.WriteLine("2 sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
                       
            Console.WriteLine(toplam(a, b));
            Console.ReadLine();
        }
    }
}
