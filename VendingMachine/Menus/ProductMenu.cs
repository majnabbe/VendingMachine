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
            UtilityMethods.ClearConsole();  

            bool menuLoop = true;

            while (menuLoop)
            {
                //Console.Clear();

                //Console.WriteLine("\nVälj skinka:\n\n1. Jakobsdals julskinka\n2. Nybergs Deli Julskinka\n3. Scan julskinka\n----------------\n4. Återgå\n");
                //Console.WriteLine("\nVälj glögg:\n\n1. Blossa\n2. Dufvenkrooks\n3. Saturnus\n----------------\n4. Återgå\n");
                //Console.WriteLine("\nVälj prinskorv:\n\n1. Härryda Karlssons prinskorv\n2. Ingelsta kalkonprinskorv\n3. Scan prinskorv\n----------------\n4. Återgå\n");


                switch (productFactory.GetType().Name)
                {
                    case "HamFactory":
                        PrintMenu.HamMenu();
                        break;
                    case "MulledWineFactory":
                        PrintMenu.MulledWineMenu(); 
                        break;
                    case "SausageFactory":
                        PrintMenu.SausageMenu();
                        break;
                }
                

                //Console.WriteLine("Välj produkt: \n");

                //for (int i = 1; i < 4; i++)
                //{
                //    ProductInformation selectedProduct = (ProductInformation)productFactory.GetProduct(i.ToString());

                //    Console.WriteLine($"{i}. {selectedProduct.Name}");
                //}

                //Console.WriteLine("---------------\n4. Återgå\n");

                //Console.Write("Ditt val: ");

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
