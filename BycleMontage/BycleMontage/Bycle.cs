using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BycleMontage
{
    public enum FrenTipi
    {
        Hidrolik, Mekanik , Kontra // 0 , 1 , 2 seklinde degerler alirlar
    }

     public enum KadroTipi
    {
        Aluminyum , Celik  //0 , 1 degerlerini alırlar.
    }


    class Bycle
    {
        public FrenTipi Fren { get; set;}
        public KadroTipi Kadro { get; set; }


        public int _ModelYili;
        private int ModelYili
        {
             get
            {
                return _ModelYili;
            }
            set
            {
                int yil = DateTime.Today.Year;
                if (value < 1990 || value > yil)
                {
                    throw new Exception("Yil ifadesi sadece 1990 ile" + yil + "arasında olabilir.");
                }
                else
                {
                    _ModelYili = value;
                }
            }
        }

        public int Yasi
        {
            get { return DateTime.Today.Year - this._ModelYili + 1; }
        }
        public override string ToString()
        {
            return this.Fren + " " + this.Kadro; 
        }



    }
}
