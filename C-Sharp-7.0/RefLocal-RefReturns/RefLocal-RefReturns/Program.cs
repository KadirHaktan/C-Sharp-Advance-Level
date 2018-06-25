using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLocal_RefReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] speakers = { "Ebubekir Doğan", "Furkan Isıtan", "Ahmet Ali" };

            //ref string speaker = ref speakers[1];

            ref string speaker = ref Find(speakers,"Ebubekir");
            speaker += " Gates";

            Console.WriteLine("Speaker Name : " + speaker);
            Console.WriteLine("Speaker Data : \n" + String.Join(",", speakers));


            //speaker = ref speakers[0]; Hata verir


            List<string> authors = new List<string>() { "Ebubekir Doğan", "Furkan Isıtan", "Ahmet Ali" };

            //ref string author = ref authors[1]; Buda hata verir

            Array.Resize(ref speakers, 1);
            speaker = "Dogan Ebubkeir";

            Console.WriteLine("Speaker Name : " + speaker);
            Console.WriteLine("Speaker Data : \n" + String.Join(",", speakers));
 
        }
        static ref string Find(string[] speakers, string speaker)
        {
            for (int i = 0; i < speakers.Length; i++)
            {
                if (speakers[i].Equals(speaker))
                {
                    return ref speakers[i];
                }
            }
            // return ref "Speaker Not Found";  hata verir. hata fırlatmamız lazım asagıdaki gibi
            throw new Exception("Speaker Not Found");

        }
    }
}
