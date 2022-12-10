﻿using System;
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
            UtilityMethods.ClearConsole();

            bool menuLoop = true;

            while (menuLoop)
            {
                //Console.Clear();

                //Console.WriteLine("***** Varuautomat *****\n");

                //Console.WriteLine("Välj produktkategori:\n\n1. Skinka\n2. Glögg\n3. Prinskorv\n----------------\n4. Avsluta\n");
                //Console.Write("Ditt val: ");

                PrintMenu.StartMenu();  

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                    case "2":
                    case "3":
                        //ProductFactory pf = ProductFactory.CreateProductFactory(userChoice);
                        ProductMenu.Menu(ProductFactory.CreateProductFactory(userChoice));
                        break;
                    case "4":
                        menuLoop = false;
                        Console.WriteLine("\nProgrammet avslutas.");
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
