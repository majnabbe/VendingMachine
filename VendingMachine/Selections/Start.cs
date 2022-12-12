using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Selections;

namespace VendingMachine.Selections
{
    public class Start
    {
        // Programmets inledande val. Väljer produktkategori för att gå vidare. Här avslutas också programmet
        // och eventuell växel återbetalas i så fall.
        public static void SelectCategoryOrExit()
        {
            UtilityMethods.ClearConsole();

            bool menuLoop = true;

            while (menuLoop)
            {
                Menus.VendingMachineText();

                Menus.PrintTotalAmountOfInsertedMoney();

                Menus.StartMenu();

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                    case "2":
                    case "3":
                        ProductSelection.SelectProduct(ProductFactory.CreateProductFactory(userChoice));
                        break;
                    case "4":
                        if (Wallet.GetWallet().TotalAmountInserted > 0)
                        {
                            Wallet.GetWallet().CalculateChange(Wallet.GetWallet().TotalAmountInserted);
                            UtilityMethods.ClearScreenAndContinue();
                        }
                        menuLoop = false;
                        UtilityMethods.ClearConsole();
                        Console.WriteLine("Programmet avslutas. Tryck på valfri tangent för att stänga fönstret.");
                        break;
                    default:
                        UtilityMethods.WrongInputInfo();
                        UtilityMethods.ClearScreenAndContinue();
                        break;
                }
            }
        }

    }
}
