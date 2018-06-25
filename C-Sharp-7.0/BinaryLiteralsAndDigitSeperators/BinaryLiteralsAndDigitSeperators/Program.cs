using System;

namespace BinaryLiteralsAndDigitSeperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 8, 16, 32 }; // Normal sayılar öylesine verildi burada
            int[] binaryLiterals = { 0b1, 0b10, 0b100, 0b1000, 0b10000, 0b1000000 };// Binary sayılar

            foreach (var bNumbers in binaryLiterals)
            {
                Console.WriteLine(bNumbers);
            }

            double income = 10_00__000;   // burada ise program calıstıgında ekranda 1000000 olarak gözükür _ler etki yapmaz.
        }
    }
}