using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            List<int> sayılar = new List<int>();
            Console.WriteLine("sayıları giriniz: ");

            for (int i = 0; i < a; i++)
            {
                sayılar.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < a-1; i++)
            {
                for (int j= 1; j < a-i; j++)
                {
                    if (sayılar[j-1] > sayılar[j])
                    {
                        int temp = sayılar[j-1];
                        sayılar[j-1] = sayılar[j];
                        sayılar[j] = temp;
                    }
                }               
            }

            for (int i = 0; i < a; i++)
            {
                Console.Write(sayılar[i]+", ");
            }
            Console.ReadLine();
        }
    }
}
