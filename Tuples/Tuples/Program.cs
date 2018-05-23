using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static Tuple<double,double> GetTotalAndProduct(double n1 , double n2)
        {
            return Tuple.Create(n1+n2 ,n2*n1);
        }
        
        public static(double total,double product) GetTotalAndProductUsingTuples(double n1,double n2)
        {
            return (n1 + n2, n2 * n1);
        }

        static void Main(string[] args)
        {
            var tp = GetTotalAndProduct(20,30);
            Console.WriteLine($"Total : {tp.Item1} ,Product : {tp.Item2} ");

            var tp2 = GetTotalAndProductUsingTuples(30,40);
            Console.WriteLine($"Total : {tp2.Item1} ,Product : {tp2.Item2} ");
            Console.WriteLine($"Total : {tp2.total} ,Product : {tp2.product} ");  // ! DİKKAT


            ValueTuple<double, double> vt = tp2;
            Console.WriteLine($"Total : {vt.Item1} ,Product : {vt.Item2} ");


            //(double t, double s) = GetTotalAndProductUsingTuples(20, 50); Buda çalışır alttaki de
            var(t,s) = GetTotalAndProductUsingTuples(10,20); // Buda aynı işi görür yukarıdaki ile
            Console.WriteLine($"Total : { t} ,Product : {s} ");

            var myself = (name:"Ebubekir Dogan",job:"student");
            Console.WriteLine($"Name : {myself.name} ,Job : {myself.job} ");
            Console.WriteLine(myself.GetType());



        }
    }
}
