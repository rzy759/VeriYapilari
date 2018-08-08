using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void kelimeCıkar(string s1,string s2)
        {
            string s3 = s2.Replace(s1, "");
            Console.WriteLine(s3);            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("çıkarılacak olan kelimeyi yazınız: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("cümleniz: ");
            string s2 = Console.ReadLine();

            kelimeCıkar(s1, s2);

            Console.ReadLine();
        }
    }
}
