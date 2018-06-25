using System;
using System.Linq;

namespace Params_Keyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(addNumbers(1, 222, 3));
            Console.ReadLine();
        }

        //Normalde uzun uzun yazmak yerine params yardımıyla buraya istedğimiz kadar parametre gönderebiliriz.
        private static int addNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}