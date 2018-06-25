using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double number1 = 10.4;
            decimal number2 = 10.4m;
            char character = 'A';
            bool condition = false;
            byte number3 = 255; // 256 ya kızar
            short number4 = 32767; //32768 deger alır
            int number5 = 2147483647; //2147483648 değer alır
            long number6 = 9223372036854775807; // 9223372036854775808 değer alır
            var number7 = 3; // Otomatik olarak integer oldu number7
            Console.WriteLine("Number1 is {0}" + number1);
            Console.WriteLine("Number2 is {0}" + number2);
            Console.WriteLine("Number3 is {0}" + number3);
            Console.WriteLine("Number4 is {0}" + number4);
            Console.WriteLine("Number5 is {0}" + number5);
            Console.WriteLine("Number6 is {0}" + number6);
            Console.WriteLine("Condition is {0}" + condition);
            Console.WriteLine("Character is {0}" + (int)character);

            Console.WriteLine((int)Days.Friday); // Dizi indisini verir.
            Console.ReadLine();
        }
    }

    public enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday,
    }
}