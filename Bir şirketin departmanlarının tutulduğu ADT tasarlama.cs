using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class departmanlar
    {
        public int depatmanİsmi { get; set; }
        public int depatmanNo { get; set; }
        public int depatmanBütcesi { get; set; }
        public int depatmanYönetici { get; set; }

        public static ArrayList kayıtEkle(departmanlar departman)
        {
            ArrayList kayıt = new ArrayList();
            kayıt.Add(departman.depatmanİsmi);
            kayıt.Add(departman.depatmanNo);
            kayıt.Add(departman.depatmanBütcesi);
            kayıt.Add(departman.depatmanYönetici);

            return kayıt;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}
