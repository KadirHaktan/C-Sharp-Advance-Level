using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //product Class
    public abstract class Screen
    {
        public abstract void Draw();
    }



    //Concrete Product
    public class WinScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Windows Screen");
        }
    } 
    //Concrete Product
    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web Screen");
        }
    }
    //Concrete Product
    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobile Screen");
        }
    }
}
