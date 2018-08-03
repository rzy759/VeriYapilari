using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi hangi sayı ile çarpılacak: ");
            int a = int.Parse(Console.ReadLine());
            int[] sayılar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (int i in sayılar)
            {
                Console.WriteLine(i*a);
            }
            Console.ReadLine();
        }
    }
}
