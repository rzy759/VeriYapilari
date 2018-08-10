using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    public class calışan
    {
        public int TCKimlikNo1 { get; set; }
        public string isim1 { get; set; }
        public string soyisim1 { get; set; }
        public int maaş1 { get; set; }
        public string çalıştıgıDepatman1 { get; set; }

        public static void kayıtEkle(calışan calışan)
        {
            calışan calıs = new calışan();
            calıs = calışan;

            ArrayList kayıt = new ArrayList();
            kayıt.Add(calıs.TCKimlikNo1);
            kayıt.Add(calıs.isim1);
            kayıt.Add(calıs.soyisim1);
            kayıt.Add(calıs.maaş1);
            kayıt.Add(calıs.çalıştıgıDepatman1);
            Console.WriteLine("kayıt eklendi ");
        }
        public static void kayıtAra(calışan calıs)
        {
            Console.WriteLine("bulundu");
        }
        public static void yazdır(calışan calıs)
        {
            Console.WriteLine(calıs);
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        public override string ToString()
        {
            return "TCKimlikNo1: " +TCKimlikNo1 + "\nisim: " +isim1+
            "\nsoyisim: "+soyisim1+"\nmaaş: "+maaş1+"\nçalıştıgıDepatman: "+çalıştıgıDepatman1;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            calışan calıs = new calışan();
            Console.WriteLine("T.C kimlik no: ");
            calıs.TCKimlikNo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İsim: ");
            calıs.isim1= Console.ReadLine();
            Console.WriteLine("Soyisim: ");
            calıs.soyisim1 = Console.ReadLine();
            Console.WriteLine("Maaş: ");
            calıs.maaş1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Çalıştığı departman: ");
            calıs.çalıştıgıDepatman1 = Console.ReadLine();

            calışan.kayıtEkle(calıs);
            calışan.kayıtAra(calıs);
            calışan.yazdır(calıs);

            Console.ReadLine();

        }
    }
}
