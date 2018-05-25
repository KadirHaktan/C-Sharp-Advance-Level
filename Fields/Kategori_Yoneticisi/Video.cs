using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kategori_Yoneticisi
{
    class Video
    {
        public void DetayGoster()
        {
            Kategori k = new Kategori();
            // aynı assembly içinde oldugu için erişti. Normalde diğer projelerden erişimi yoktur.
            k.Adi = "Ebubekir";
            k.KarakterSayisi = 5;

        }
    }
}
