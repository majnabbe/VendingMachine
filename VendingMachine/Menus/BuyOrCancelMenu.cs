using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Menus
{
    public class BuyOrCancelMenu
    {
        public static void Menu(IProduct product)
        {
            UtilityMethods.ClearConsole();

            PrintMenu.BuyOrCancelMenu();

            if (Console.ReadKey().Key == ConsoleKey.K)
            {
                UtilityMethods.ClearConsole();
                product.Buy();
                product.Use();
                UtilityMethods.ClearScreenAndContinue();
            }
            else
            {
                UtilityMethods.ClearConsole();
                return;
            }
        }
    }
}
