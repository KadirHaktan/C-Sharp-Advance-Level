using FasadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Facade
    {
        //Bu alt sınıfları içeriyor olması gerekiyor.
        private Bank _bank;
        private CentralBank _centralBank;
        private Credit _credit;
        //Bunları kullanabilmek içinde constructorda initialize etmemiz gerekiyor.
        public Facade()
        {
            _bank = new Bank();
            _centralBank = new CentralBank();
            _credit = new Credit();

        }
         public void useCredit(Customer customer , decimal request)
        {
            if (_centralBank.blackListControl(customer.TcNumber)&& (_credit.stateUseCredit(customer)))
            {
                _bank.UseCredit(customer, request);
                Console.WriteLine("Credit used ");
            }
        }

    }
}
 