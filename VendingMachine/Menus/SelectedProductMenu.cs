using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Menus
{
    public class SelectedProductMenu
    {
        public static void Menu(IProduct product)
        {
            Console.Clear();

            // Cast för att komma åt properties från den abstrakta klassen.
            ProductInformation selectedProduct = (ProductInformation)product;

            //Console.WriteLine($"Kategori: {selectedProduct.Category}\nNamn: {selectedProduct.Name}\nPris: {selectedProduct.Price} kr");

            bool menuLoop = true;

            while (menuLoop)
            {
                //Console.Clear();

                Console.WriteLine($"Kategori: {selectedProduct.Category}\nNamn: {selectedProduct.Name}\nPris: {selectedProduct.Price} kr");

                Console.WriteLine("\n1. Visa beskrivning\n2. Köp\n ----------------\n3. Återgå.\n");
                Console.Write("Ditt val: ");

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                        product.Description();
                        UtilityMethods.ClearScreenAndContinue();
                        break;
                    case "2":
                        BuyOrCancelMenu.Menu(product);
                        break;
                    case "3":
                        menuLoop = false;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Felaktig inmatning. Försök igen: ");
                        UtilityMethods.ClearScreenAndContinue();
                        break;
                }
            }
        }
    }
}
