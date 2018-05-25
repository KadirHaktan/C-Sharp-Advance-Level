using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();
            Console.WriteLine("");
            Factory factory2 = new Factory(new Db2Factory());
            factory2.Start();
        }
    }
}
