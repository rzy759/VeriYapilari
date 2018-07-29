using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] sayılar = new int[] { 2, 3, 6, 3, 4, 1, 9, 8, 2, 6 };
            

            Console.WriteLine("en büyük sayı:"+ sayılar.Max());
            Console.ReadLine();
        }
    }
}
