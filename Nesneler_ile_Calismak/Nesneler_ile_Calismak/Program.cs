using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler_ile_Calismak
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
            Console.WriteLine("Kaç Klip nesnesi ile Çalışacaksiniz :");
            string cevap = Console.ReadLine(); // Kullanicidan Değer almak için kullanılır.
            int KlipAdet = int.Parse(cevap); // String to Int olayı

        }
    }
}
