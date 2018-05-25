using System;
using Fields.App_Code;
using Kategori_Yoneticisi;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Makale m = new Makale("Başlık Gelecek","Detay Bilgisi Gelecek");
            Makale m1 = new Makale("Başlık Gelecek", "Detay Bilgisi Gelecek",true); //3 parametreli contructor'a gidecek.

            /*
            
            Field'ların default başlangıc degeri 
            string : null 
            bool : false
            DateTime : Min (01,01,001 00:00:00 AM or PM)
            int :0
            ondalıklı sayıların ise 0.0 

            olarak otomatik atama işlemi gerçekleşir.
            */

            Console.WriteLine("Başlık : " + m.Baslik);
            Console.WriteLine("Açıklama : " + m.KısaAciklama);
            Console.WriteLine("Detay : " +m.Detay);
            Console.WriteLine("Manşette Görünsün mü? " + m.MansetteGorusunMu.ToString());
            Console.WriteLine("Oluşturulma Tarihi : " + m.OlusturulmaTarihi.ToString());
            Console.WriteLine("Fotoğraf Sayısı : " + m._fotografSayisi.ToString());

            m.MansetteGorusunMu = false;

            //fieldları kontrollü olarak makale sınıfını kullanan sınıflara acmak lazım bunun için propert yapılır.Böylece 1 milyon degeri verilemez cünkü kontrolden gecer.
            m._fotografSayisi = 10000000;


            Kategori k = new Kategori();
            k.Adi = "";
            k.KarakterSayisi = 5;








            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
