using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 boyutlu dizinin boyutlarını giriniz: ");
            Console.Write("satır: ");
            int sa = int.Parse(Console.ReadLine());
            Console.Write("sutun: ");
            int su = int.Parse(Console.ReadLine());
            string[,] A = new string[sa, su];
            Console.WriteLine("2 boyutlu dizinin elemanlarını giriniz");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    A[i, j] = Console.ReadLine(); 
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sa; i++)
            {
                string[] dizi = new string[su];
                for (int j = 0; j < su; j++)
                {
                    dizi[j] = A[i, j];
                }
                for (int k = 0; k < su; k++)
                {
                    Console.Write(dizi[k]+" ");
                }
                Console.WriteLine();
            }
          
            Console.ReadLine();
        }
    }
}
