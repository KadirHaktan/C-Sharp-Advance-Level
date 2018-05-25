using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirAdimİlerisi
{
    class Klip
    {
        public Kisi SarkiciAdi;
        public string SarkiAdi;
        public string DosyaAdi;

    }

    class Kisi
    {
        public long TCKimlikNo;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Klip k = new Klip();
            k.DosyaAdi = "Papatya.wmv";
            k.DosyaAdi = "Papatya";
            k.SarkiciAdi.Ad= "Teoman"; /// Dikkat! :) Hata verir.
            k.SarkiciAdi.Soyad= "Teoman";
            k.SarkiciAdi.TCKimlikNo = 1234567890;
            k.SarkiciAdi.DogumTarihi = new DateTime(2010,3,2);


            Console.WriteLine(k.SarkiciAdi.DogumTarihi.Year);
        }
    }
}
