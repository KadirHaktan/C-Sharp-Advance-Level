using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Kavrami
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
            Ogrenci test; // default degeri null'dir.
                          //  test.Ad = "Ebubekir"; // test degisken oldugu ver hafızada hiçbir ögrenci nesnesi olmadıgı için direk atama yapamayız.
////////////////////////
            Ogrenci denek = new Ogrenci();//Bu sekilde olur ama
            denek.Ad = "Ebubekir"; //Bunu kabul etmesinin sebebi memoryde denek adlı nesne olusturuldugu için Ad soyad ve nosu belli olmayan bos birşey tanımaldık.

///////////////////////////////
            Ogrenci x = new Ogrenci();
            x.Ad = "EBubekir";
            Console.WriteLine(x.Ad[0]); // E harfi gelir bu sekildede ulaşabiliriz.
            x = new Ogrenci(); // hafızada yeni nesne olusturuldu .
            Console.WriteLine("-------------");
            Console.WriteLine(x.Ad);

///////////////////////////////////////////////////
            Ogrenci s = new Ogrenci(); // yeni nesne tanımlandı.
            s.OkulNo = 6599;
            s.Ad = "Ceyhun";
            s.Soyad = "asdasd";

            Ogrenci f = s;
            
            Console.WriteLine(f.Ad);
            Console.WriteLine(s.Ad);

            f = new Ogrenci();  // yeni ögrenciyi işaret ediyor. s halen eski  Ceyhun adli ögrenciyi işaret ediyor.
            f.Soyad = "Doğan";
            Console.WriteLine(f.Ad);
            s = f;
            Console.WriteLine(f.Soyad);
            Console.WriteLine(f.Ad); //boş satır üretir.

            s = new Ogrenci();

            s = null;
            f = null; 

            //////////////////////////////////////////
            Console.ReadKey();
        }
    }
}
