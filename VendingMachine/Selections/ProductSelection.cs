using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Selections
{
    public class ProductSelection
    {
        // Tar fram produktkategorimeny och väljer produkt.
        public static void SelectProduct(ProductFactory productFactory)
        {
            UtilityMethods.ClearConsole();  

            bool menuLoop = true;

            while (menuLoop)
            {
                Menus.PrintTotalAmountOfInsertedMoney();

                // Väljer meny enligt den produktkategori (ProductFactory) som skickas in i metoden.
                switch (productFactory.GetType().Name)
                {
                    case "HamFactory":
                        Menus.HamMenu();
                        break;
                    case "MulledWineFactory":
                        Menus.MulledWineMenu(); 
                        break;
                    case "SausageFactory":
                        Menus.SausageMenu();
                        break;
                }
      
                string userChoice = UtilityMethods.CustomerInput();

                // Väljer produkt.
                switch (userChoice)
                {
                    case "1":
                    case "2":
                    case "3":
                        SelectedProduct.SelectProductAlternatives(productFactory.GetProduct(userChoice));
                        break;
                    case "4":
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
