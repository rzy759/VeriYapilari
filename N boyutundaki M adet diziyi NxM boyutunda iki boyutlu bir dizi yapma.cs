using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç tane dizi var");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("diziler kaç elemanlı: ");
            int N = int.Parse(Console.ReadLine());

            string[,] ikiBoyut = new string[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] dizi = new string[N];
                Console.WriteLine("dizinin elemanlarını giriniz: ");
                for (int k = 0; k < N; k++)
                {
                    dizi[k] = Console.ReadLine();
                }
                for (int j = 0; j < N; j++)
                {
                    ikiBoyut[i, j] = dizi[j];
                }

            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(ikiBoyut[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();     
                     
        }
    }
}
