using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Selections
{
    public class BuyOrCancel
    {
        // Genomför köpet av en produkt eller avbryter. Tryck på [K] (går med liten bokstav) för att köpa.
        public static void BuyProductOrCancel(IProduct product)
        {
            UtilityMethods.ClearConsole();

            Menus.BuyOrCancelMenu();

            if (Console.ReadKey().Key == ConsoleKey.K)
            {
                UtilityMethods.ClearConsole();
                product.Buy();
            }
            else
            {
                UtilityMethods.ClearConsole();
                return;
            }
        }
    }
}
