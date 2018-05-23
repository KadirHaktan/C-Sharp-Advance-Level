using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kategori_Yoneticisi
{
    //ara tiplerin (sınıf , yapı,interface , temsilci ,numaralandırıcı)
    //erişim belirleyicileri arasında 'private' yoktur.!! 

    public class Kategori
    {
        public string Adi;
        internal int KarakterSayisi; //internal erişim belirleyicisi sadece yazıldıgı assembly içerisinde kullanabilir.
        private byte ReklamAdet;
    }
}
