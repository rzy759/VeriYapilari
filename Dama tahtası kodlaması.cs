using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0) Console.Write("0 ");
                    else Console.Write("1 ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
