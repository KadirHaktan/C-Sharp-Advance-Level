using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    enum ScreenModel
    {
        Windows,
        Web,
        Mobile
    }
    //Creator Class
    class Creator
    {

        /// <summary>
        ///Factory Method
        /// </summary>
        /// <param name="screenModel">Screen Type</param>
        /// <returns>Asıl ürünü tasıyan referans</returns>
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;

            switch (screenModel)
            {
                case ScreenModel.Windows: screen = new WinScreen(); break;
                case ScreenModel.Web: screen = new WebScreen(); break;
                case ScreenModel.Mobile: screen = new MobileScreen(); break;
                default: break;
            }

            return screen;
        }

    }

    abstract class Creator2
    {
        public abstract Screen ScreenFactory();
    }
    class WinScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WinScreen();
        }
    }
    class WebScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WebScreen();
        }
    }
    class MobileScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new MobileScreen();
        }
    }
}
