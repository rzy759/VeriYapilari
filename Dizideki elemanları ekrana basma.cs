using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void ekranaBas(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        
        static void ekranaBas(string[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            string[] metin = new string[] { "ali", "veli", "ahmet" };
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ekranaBas(metin);
            Console.WriteLine("----------");
            ekranaBas(data);

            Console.ReadLine();
        }
    }
}
