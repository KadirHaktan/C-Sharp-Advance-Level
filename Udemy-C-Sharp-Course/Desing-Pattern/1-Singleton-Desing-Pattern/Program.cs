using System;

namespace _1_Singleton_Desing_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save(); // Bu methodu private static olarak tanımlamıs olsaydık ulaşamazdık bu sekilde
        }
    }

    internal class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static object _lockObject = new object(); // Bunu yapmamızdaki temel amac bir nesneyi iki kişi aynı anda üretmek isterse bunu enegellemek
        // temel amacımız iki nesne üretilirse singleton patterne ters olmus oluyor bunun içinde bunu kilit kontrolü ile yapacagiz.

        private CustomerManager()
        {
        }

        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved.!");
        }
    }
}