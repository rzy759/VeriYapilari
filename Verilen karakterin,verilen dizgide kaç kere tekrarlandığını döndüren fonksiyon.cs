using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static int tekrarSayısı(string s,char c)
        {
            int sayac = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) sayac++;
            }
             
            return sayac;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bir dizgi giriniz: ");
            string s = Console.ReadLine();
            Console.WriteLine("karakter giriniz: ");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine(tekrarSayısı(s,c));
            Console.ReadLine();

        }
    }
}
