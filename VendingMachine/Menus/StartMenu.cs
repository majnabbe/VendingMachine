using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Menus
{
    public class StartMenu
    {
        public static void Menu()
        {
            Console.Clear();

            bool menuLoop = true;

            while (menuLoop)
            {
                //Console.Clear();

                Console.WriteLine("***** Varuautomat *****\n");

                Console.WriteLine("Välj produktkategori:\n\n1. Skinka\n2. Glögg\n3. Prinskorv\n----------------\n4. Avsluta\n");
                Console.Write("Ditt val: ");

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                    case "2":
                    case "3":
                        ProductFactory pf = ProductFactory.CreateProductFactory(userChoice);
                        ProductMenu.Menu(pf);
                        break;
                    case "4":
                        menuLoop = false;
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
