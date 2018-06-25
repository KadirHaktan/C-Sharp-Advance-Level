using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
           // var add = new Func<int, int, int>((no1, no2) => no1 + no2); // iki sayının toplamını veren local function yazmıs olduk.
           //eğer yukarıdaki olmasaydı asagıdaki gibi bir fonksiyon tanımı yapacaktık
            var result = add(10,20);

            Console.WriteLine($"Sum of 10 and 20 is : {result}");

            int add(int s1,int s2)
            {
                return s1 + s2;
            }
        }
    }
}
