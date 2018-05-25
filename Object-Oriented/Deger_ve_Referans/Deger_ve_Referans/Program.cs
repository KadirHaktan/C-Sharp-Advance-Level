using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deger_ve_Referans
{
    class Koordinat
    {
        public int X;
        public int Y;

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a; // a'nın degerine ulaşılır ve a'nın tasıdıgı degerin kopyası b'ye verilir.
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 4;
            Console.WriteLine(a); // a degisti ancak b hala degerini koruyor.
            Console.WriteLine(b);

//////////////////////////////////////////////////////////////////
            Koordinat k = new Koordinat(); //hafızaya Koordinat türünde bir nesne çıkar.
            k.X = 10;
            k.Y = 10;


            Koordinat f = k; // K içerisindeki tasınan degerin kopyası f'ye atandi.

            k.X = 15;// X in degeri 15 olarak degisti.

            Console.WriteLine(f.X); // 15 cıkar
            Console.WriteLine(f.Y); // 10 cıkar degistirme yapılmadıgı için.

            Console.ReadKey();
        }
    }
}
