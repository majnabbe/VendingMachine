using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Menus
{
    public class ProductMenu
    {
        public static void Menu(ProductFactory productFactory)
        {
            Console.Clear();

            bool menuLoop = true;

            while (menuLoop)
            {
                //Console.Clear();

                //Console.WriteLine("\nVälj glögg:\n\n1. Blossa\n2. Dufvenkrooks\n3. Saturnus\n----------------\n4. Återgå\n");

                Console.WriteLine("Välj produkt: \n");

                for (int i = 1; i < 4; i++)
                {
                    ProductInformation selectedProduct = (ProductInformation)productFactory.GetProduct(i.ToString());

                    Console.WriteLine($"{i}. {selectedProduct.Name}");
                }

                Console.WriteLine("---------------\n4. Återgå\n");

                Console.Write("Ditt val: ");

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                    case "2":
                    case "3":
                        SelectedProductMenu.Menu(productFactory.GetProduct(userChoice));
                        break;
                    case "4":
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
