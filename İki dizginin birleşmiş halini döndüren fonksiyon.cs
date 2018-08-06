using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void birleştir(string s1,string s2)
        {
            Console.WriteLine(s1+" "+s2);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("iki dizgi giriniz: ");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            birleştir(s1, s2);
            Console.ReadLine();
        }
    }
}
