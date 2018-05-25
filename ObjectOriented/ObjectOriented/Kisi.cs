using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public enum Cinsiyet
    {
        Bay,Bayan
    }
    class Kisi
    {
        private Cinsiyet _cinsiyeti;
        private Cinsiyet Cinsiyeti
        {
            get { return _cinsiyeti;}
            set { _cinsiyeti = value;}
        }

        private String _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private String _ili;
        public string Ili
        {
            get { return _ili; }
            set { _ili = value; }
        }
        private String _soyad;
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        private DateTime _dogumTarihi;
        public DateTime DogumTarii
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        private String _tcKimlikNo;
        public string TcKimlikNo
        {
            get { return _tcKimlikNo; }
            set { _tcKimlikNo = value; }
        }
        
        public string KisiBilgileri()
        {
            StringBuilder sbd = new StringBuilder();
            sbd.Append("Ad : ");
            sbd.AppendLine(Ad);
            sbd.Append("Soyad : ");
            sbd.AppendLine(Soyad);
            sbd.Append("Dogum Tarihi : ");
            sbd.AppendLine(DogumTarii.ToShortDateString());
            sbd.Append("Tc Kimlik No : ");
            sbd.AppendLine(TcKimlikNo);
            return sbd.ToString();
        }


    }
}
