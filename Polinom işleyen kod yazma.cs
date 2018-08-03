using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("polinomun katsayılarını boşluk koyarak giriniz: ");
            string katsayı = Console.ReadLine();
            string[] katsayılar = katsayı.Split(' ');
            double pol = 0;
            for (int i = 0; i < katsayılar.Length; i++)
            {
                Console.Write(katsayılar[i]+"x^"+(katsayılar.Length-i)+" ");
            }
            
            Console.WriteLine(", x in değerini giriniz: ");
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < katsayılar.Length; i++)
            {
                pol += int.Parse(katsayılar[i]) * Math.Pow(x, katsayılar.Length - i);
            }

          
            Console.WriteLine("polinomun değeri: "+pol);
            Console.ReadLine();
        }
    }
}
