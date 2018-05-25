using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields.App_Code
{
    //Davranış : Metodlar
    //Ozellik  : Field(Alan) - Bu nesnenin nesi vardır sorusunun cevabıdır.



    class Makale
    {
        //geri deger dondurmez yapıcı methodlar.Her sınıfın yazsakta yazmasakta bir constructor'ı vardır.
        //constructor : Sınıf nesnesi örneklenirken , bu degerler mutlaka verilmeli.
        // varsayılan constructor'ı ezdik.varsayılan olan parametresiz olana denir.
        public Makale(string baslik , string detay)
            {
            //this aynı degiskenleri kullanıp karısıklıgı onlemek için kullanılır.
            this.Baslik = baslik;
            this.Detay = detay;
            this.OlusturulmaTarihi = BuAniYolla();
        }
        //Overloading(Aşırı Yükleme) işlemi gerçekleştirildi.
        public Makale(string baslik, string detay,bool masetteCiksinMi)
        {
           
            this.Baslik = baslik;
            this.Detay = detay;
            this.MansetteGorusunMu = masetteCiksinMi;
            this.OlusturulmaTarihi = BuAniYolla();
        }
        public Makale()
        {
            // Varsayılan Contstructor'ı az önce ezmiştik yani es geçmiştik. İstersek şayet bu secegnegi kullanıcıya geri verebiliriz.
        }
        public string Baslik;
        public DateTime OlusturulmaTarihi;
        //public string KısaAciklama;
        public string Detay;
        public bool MansetteGorusunMu =true; // field degeri degistirilebilir.
        public int _fotografSayisi;
        // üç tane koyduk mu bundan xml yorum satırı olusur.
        /// <summary>
        /// Güncel Tarihi Gösterir.private üyeler sınıfı içindeki işlemleri kolaylaştırmak için kullanılır.
        /// </summary>
        /// <returns></returns>
        private DateTime BuAniYolla()
        {
            return DateTime.Now;
        }
    }
}
