using SinifKutuphanesi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{

 
  
    
     
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //Tost'u kullanamayız cunku farklı assemblyde yer alıyor.Testi kullanmamızı saglayan seyse public olması 
            //t.uye3 erişemeyiz çünkü private oldugu için sadece kendi classında gecerlidir.
            //internal aynı assembly içersindeki erişime acıktır.
        }
    }
}
