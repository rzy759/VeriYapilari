using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[] { 1, 2, 3 };
            int[] dizi2 = new int[] { 4, 5, 6 };
            int[] diziler = new int[dizi1.Length + dizi2.Length];
            for (int i = 0; i < dizi1.Length; i++)
            {
                diziler[i] = dizi1[i];
            }
            for (int i = dizi1.Length; i < dizi2.Length+dizi1.Length; i++)
            {
                diziler[i] = dizi2[i - dizi1.Length];
            }
            foreach (int i in diziler)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
