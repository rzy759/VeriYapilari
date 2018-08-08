using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("email adresi: ");
            string s1 = Console.ReadLine();
            string[] S = s1.Split('@');
            Console.WriteLine("kullanıcı adı: "+S[0]);
            Console.WriteLine("hostu: "+S[1]);
            Console.ReadLine();
        }
    }
}
