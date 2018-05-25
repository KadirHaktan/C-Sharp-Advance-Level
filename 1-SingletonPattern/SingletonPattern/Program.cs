using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        /*Singleton pattern kullanmamızın amacı : Bir nesnenin çalışma zamanında tek olmasını istememiz ve bunu
        da garanti altına almak istiyorsak bu patterni kullanırız.   
        */
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.Id.ToString());

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2  .Id.ToString());
        }

        //İki ekran cıktısıda aynı olacak cunku amacımız tek cıktı almak.
    }
}
