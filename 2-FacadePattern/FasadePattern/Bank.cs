using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadePattern
{
    class Bank
    {
        public bool UseCredit(Customer customer, decimal amountRequest)
        {
            return true;

        }
    }
}
