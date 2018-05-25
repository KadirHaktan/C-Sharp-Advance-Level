using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. yol bu

            //Creator creator = new Creator();
            //Screen screenWindows = creator.ScreenFactory(ScreenModel.Windows);// Screen factory geriye screen türüünden deger döndürür.   
            //Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
            //Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

            //screenWindows.Draw();
            //screenWeb.Draw();
            //screenMobile.Draw();

            //2.yol

            Creator2[] creators = {new WinScreenCreator(),new MobileScreenCreator(),new WebScreenCreator()};
            foreach (Creator2 creator in creators)
            {
                Screen screen = creator.ScreenFactory();
                screen.Draw();
            }
        }
    }
}
