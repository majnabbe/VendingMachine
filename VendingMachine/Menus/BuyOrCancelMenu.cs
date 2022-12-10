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
            Console.Clear();
            Console.Write("Tryck [k] för att genomföra köpet eller annan bokstav för att avbryta: ");

            if (Console.ReadKey().Key == ConsoleKey.K)
            {
                Console.Clear();
                product.Buy();
                product.Use();
                UtilityMethods.ClearScreenAndContinue();
            }
            else
            {
                Console.Clear();
                return;
            }
        }
    }
}
