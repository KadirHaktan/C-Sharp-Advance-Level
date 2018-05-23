using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerReferans
{
    class KoordinatC
    {
        public int X;
        public int Y;

    }
    struct KoordinatS
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            KoordinatC c1 = new KoordinatC();
            c1.X = 4;
            c1.Y = 5;
            KoordinatC c2 = c1;
            c1.X = 555;
            Console.WriteLine(c2.X); // 555 sonucunu çıkarır bize.


            KoordinatS s1 = new KoordinatS();
            s1.X = 4;
            s1.Y = 5;
            KoordinatS s2 = s1;
            s1.X = 555;
            Console.WriteLine(s2.X); // burada cıktı 4 olarak cıkar.burada 555 yapmamasının nedeni struct olarak tanımlanmıs olm
            //referans türlüler nesnenin adresini tasırlar yani s2= s1 dedigimizde adresin bir kopyasını s2 nesnesine atar.
            //deger türlüler ise nesnenin adrsini degil nesnenin kendisini tasırlar.

            Console.ReadKey();
        }

    }
}
