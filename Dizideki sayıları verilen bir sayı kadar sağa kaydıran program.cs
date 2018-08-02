using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("dizi ne kadar sağa kaydırılsın");
            int a = int.Parse(Console.ReadLine());
            int[] yeni = new int[sayılar.Length + a];

            for (int i = 0; i < a; i++)
            {
                yeni[i] = 0;
            }
            for (int i = a; i < yeni.Length; i++)
            {
                yeni[i] = sayılar[i-a];

            }
            foreach (int i in yeni)
            {
                Console.Write(i+" ");
            }           

            Console.ReadLine();

        }
    }
}
