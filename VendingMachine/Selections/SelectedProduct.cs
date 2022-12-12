using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Selections;

namespace VendingMachine.Selections
{
    public class SelectedProduct
    {
        // Hanterar de olika alternativen för vald produkt.
        public static void SelectProductAlternatives(IProduct product)
        {
            UtilityMethods.ClearConsole();

            // Cast för att komma åt property:erna från den abstrakta klassen.
            ProductInformation selectedProduct = (ProductInformation)product;

            bool menuLoop = true;

            while (menuLoop)
            {
                Menus.PrintTotalAmountOfInsertedMoney();

                Menus.SelectedProductMenu(selectedProduct);

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                        product.Description();
                        UtilityMethods.ClearScreenAndContinue();
                        break;
                    case "2":
                        Wallet.GetWallet().InsertMoney(product);
                        break;
                    case "3":
                        BuyOrCancel.BuyProductOrCancel(product);
                        break;
                    case "4":
                        Wallet.GetWallet().ReturnChange();
                        break;
                    case "5":
                        menuLoop = false;
                        UtilityMethods.ClearConsole();
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
