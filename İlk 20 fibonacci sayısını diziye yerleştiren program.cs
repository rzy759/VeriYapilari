using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[20];
            sayılar[0] = 1;
            sayılar[1] = 1;
            for (int i = 2; i < 20; i++)
            {
                sayılar[i] = sayılar[i - 1] + sayılar[i - 2];

            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"-) "+sayılar[i]);
            }
            Console.ReadLine();
        }
    }
}
