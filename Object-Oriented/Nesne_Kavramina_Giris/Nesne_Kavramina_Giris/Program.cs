using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Kavramina_Giris
{
    class Klip
    {

        public string SarkiciAdi;
        public string SarkiAdi;
        public string DosyaAdi;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32 degisken = 5;

            //Nesne
            //Değişken
            //Tip
            //Sınıf

            Double noktaliSayi = 4.5;
            String kelime = "Software";
            Boolean durum = true;
            Char karakter = 'C';
            ////////////////////////////////////////////////////
            string dosyaAdi = "Ben Olsaydım.wmv";
            string sarkici = "Mustafa Sandal";
            string sarkiAdi = "Ben Olsaydım";

            string dosyaAdi2 = "Hepsi Aşktan.wmv";
            string sarkici2 = "Mustafa Sandal";
            string sarkiAdi2 = "Hepsi Aşktan";

            Console.WriteLine(sarkici);
            

            /// burası cok optimize değil en iyisi Class yapısı
            ////////////////////////////////////////////////////

            Klip k = new Klip(); // hafızaya bir klip nesnesi   
            Console.WriteLine("*");
            Console.WriteLine(k.SarkiAdi);
            Console.WriteLine("*");

            ////////////////////////////////////////////////////


            Klip j1 = new Klip();
            j1.SarkiAdi ="X";
            j1.SarkiciAdi ="A";
            j1.DosyaAdi ="F";

            Klip j2 = new Klip();
            j2.SarkiAdi = "Y";
            j2.SarkiciAdi = "B";
            j2.DosyaAdi = "F";

            Klip j3 = new Klip();
            j3.SarkiAdi = "Z";
            j3.SarkiciAdi = "C";
            j3.DosyaAdi = "F";

            Console.WriteLine(j2.SarkiAdi);
            ///////////////////////////////////////////////////////

            int[] rakamlar; // Ortamda(bellekte) simdilik bir dizi yok. New ile türetmedik
            rakamlar = new int[3];// new anahtar kelimesi ile 3 elemanlı bir int dizisi tanımlandı.

            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[1]);
            Console.WriteLine(rakamlar[2]);

            ////////////// -> Şimdi Klip Dizisine geçiyoruz....

            Klip[] klip = new Klip[3]; // Klip classının klip türünden olan 3 elemanlı bir Klip dizisi tanımlandı.
            klip[0] = new Klip();
            klip[0].SarkiAdi = "Bahçevan";
            klip[0].SarkiciAdi = "Zeki Müren";
            klip[0].DosyaAdi = "Bahcevan.wmv";

            klip[1] = j1;
            klip[2] = j2;

            for (int i =0;i<klip.Length;i++)
            {
                Console.WriteLine(i+1 +  ". Sarki Adı : " + klip[i].SarkiAdi);
            }

            Console.ReadKey();
        }
    }
}
