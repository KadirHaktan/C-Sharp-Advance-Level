using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_NesneKavrami
{
    class Ogrenci
    {
        public int OkulNo;
        public string Ad;
        public string Soyad;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();//Ogrenci bellege cıkarıldı.
            Ogrenci ogrenci2 = new Ogrenci(); // new'i her kullandıgımızda bellege yeni alan acılır

            ogrenci.Ad = "Ebubekir";
            ogrenci.Soyad = "Doğan";
            ogrenci.OkulNo = 15060765;

            ogrenci2.Ad = "Kerim";
            ogrenci2.Soyad = "Saraç";
            ogrenci2.OkulNo = 1002;

            Console.WriteLine(ogrenci2.Ad);
//////////////////////////////////////////////////////////
            Ogrenci[] talebeler = new Ogrenci[2];
            talebeler[0] = ogrenci;
            talebeler[1] = ogrenci2;

            for(int i=0;i<talebeler.Length;i++)
            {
                Console.WriteLine(talebeler[i].Ad + " " + talebeler[i].Soyad); // yazdırma işlemi bu kadar
            }
            Console.WriteLine(talebeler[0]);


/////////////////////////////////////////
            int elemanSayisi = 5;
            Ogrenci[] students = new Ogrenci[elemanSayisi];
            students[0]=new Ogrenci();
            students[0].OkulNo = 1006;
            students[0].Ad = "Ebubekir";
            students[0].Soyad = "Doğan";

          


            Ogrenci[] childrens= new Ogrenci[students.Length];
            Console.WriteLine(childrens[0].Ad);
////////////////////////////
            Ogrenci test; // default deger nulldir
            int rastgeleDeger = 5;
/////////////////////////////////////

            Console.ReadKey(); // komut satırının ekrandan gitmesini engeller ve tusa basınca kapanmasını saglar.
        }
    }
}
