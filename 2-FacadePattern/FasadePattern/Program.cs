using FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadePattern
{
    class Program
    {
        //Bunun gercek hayattaki kullanim amacı : 
        //Cok karmasık alt sistem operasyonlarının göz önüne alındıgı durumlarda Fasade Pattern cok ise yarar.

        //Buranın istemci oldugunu varsayalim.

        static void Main(string[] args)
        {
            Facade fc = new Facade(); 
            fc.useCredit(new Customer { CustomerName = "Ebubekir", TcNumber = "1231234",CustomerNumber=1001},1000);
        }
    }
}
