using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void harfDön(string s,int i)
        {
            Console.WriteLine(s[i-1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bir dizgi giriniz: ");
            string s = Console.ReadLine();
            Console.WriteLine("bir sayı giriniz: ");
            int i = int.Parse(Console.ReadLine());
            
            harfDön(s, i);
            Console.ReadLine();
        }
    }
}
