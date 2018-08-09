using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("T.C kimlik no: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("İsim: ");
            string b = Console.ReadLine();
            Console.WriteLine("Soyisim: ");
            string c = Console.ReadLine();
            Console.WriteLine("Maaş: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Çalıştığı departman: ");
            string e = Console.ReadLine();

            ArrayList liste = new ArrayList();
            liste.Add(a);
            liste.Add(b);
            liste.Add(c);
            liste.Add(d);
            liste.Add(e);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("aradığınız bilgi: ");
            var f = Console.ReadLine();         
            if (liste.Contains(f)) Console.WriteLine("aradığınız bilgi listede mevcut");
            else Console.WriteLine("aradığınız bilgi listede mevcut değil");
            
            Console.ReadLine();
        }
    }
}
