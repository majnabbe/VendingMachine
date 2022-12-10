using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Factories;

namespace VendingMachine
{
    public class UtilityMethods
    {
        //public static void StartMenu()
        //{
        //    Console.Clear();    

        //    bool menuLoop = true;

        //    while (menuLoop)
        //    {
        //        //Console.Clear();

        //        Console.WriteLine("***** Varuautomat *****\n");

        //        Console.WriteLine("Välj produktkategori:\n\n1. Skinka\n2. Glögg\n3. Prinskorv\n----------------\n4. Avsluta\n");
        //        Console.Write("Ditt val: ");

        //        string userChoice = CustomerInput();

        //        switch (userChoice)
        //        {
        //            case "1":
        //            case "2":
        //            case "3":
        //                ProductFactory pf = ProductFactory.CreateProductFactory(userChoice);
        //                ProductMenu(pf);
        //                break;
        //            case "4":
        //                menuLoop = false;
        //                break;
        //            default:
        //                Console.Write("Felaktig inmatning. Försök igen: ");
        //                ClearScreenAndContinue();
        //                break;
        //        }
        //    }
        //}




        //public static void ProductMenu(ProductFactory productFactory)
        //{
        //    Console.Clear();

        //    bool menuLoop = true;

        //    while (menuLoop)
        //    {
        //        //Console.Clear();

        //        //Console.WriteLine("\nVälj glögg:\n\n1. Blossa\n2. Dufvenkrooks\n3. Saturnus\n----------------\n4. Återgå\n");

        //        Console.WriteLine("Välj produkt: \n");

        //        for (int i = 1; i < 4; i++)
        //        {
        //            ProductInformation selectedProduct = (ProductInformation)productFactory.GetProduct(i.ToString());

        //            Console.WriteLine($"{i}. {selectedProduct.Name}");
        //        }

        //        Console.WriteLine("---------------\n4. Återgå\n");

        //        Console.Write("Ditt val: ");

        //        string userChoice = CustomerInput();

        //        switch (userChoice)
        //        {
        //            case "1":
        //            case "2":
        //            case "3":
        //                SelectedProduct(productFactory.GetProduct(userChoice));
        //                break;
        //            case "4":
        //                menuLoop = false;
        //                Console.Clear();
        //                break;
        //            default:
        //                Console.Write("Felaktig inmatning. Försök igen: ");
        //                ClearScreenAndContinue();
        //                break;
        //        }
        //    }
        //}





        ////public static void MulledWineMenu()
        ////{           
        ////    bool menuLoop = true;

        ////    while (menuLoop)
        ////    {
        ////        Console.Clear();    

        ////        Console.WriteLine("\nVälj glögg:\n\n1. Blossa\n2. Dufvenkrooks\n3. Saturnus\n----------------\n4. Återgå\n");
        ////        Console.Write("Ditt val: ");

        ////        string userChoice = CustomerInput();

        ////        switch (userChoice)
        ////        {
        ////            case "1":
        ////            case "2":
        ////            case "3":
        ////                SelectedProduct(ProductFactory.GetMulledWine(userChoice));
        ////                break;
        ////            case "4":
        ////                menuLoop = false;
        ////                break;
        ////            default:
        ////                Console.Write("Felaktig inmatning. Försök igen: ");
        ////                break;
        ////        }
        ////    }
        ////}

        //public static void SelectedProduct(IProduct product)
        //{
        //    Console.Clear();

        //    // Cast för att komma åt properties från den abstrakta klassen.
        //    ProductInformation selectedProduct = (ProductInformation)product;

        //    Console.WriteLine($"Kategori: {selectedProduct.Category}\nNamn: {selectedProduct.Name}\nPris: {selectedProduct.Price} kr");

        //    bool menuLoop = true;

        //    while (menuLoop)
        //    {
        //        //Console.Clear();

        //        Console.WriteLine("1. Visa beskrivning\n2. Köp\n ----------------\n3. Återgå.\n");
        //        Console.Write("Ditt val: ");

        //        string userChoice = CustomerInput();

        //        switch (userChoice)
        //        {
        //            case "1":
        //                product.Description();
        //                ClearScreenAndContinue();
        //                break;
        //            case "2":
        //                BuyOrCancel(product);
        //                break;
        //            case "3":
        //                menuLoop = false;
        //                Console.Clear();
        //                break;
        //            default:
        //                Console.Write("Felaktig inmatning. Försök igen: ");
        //                ClearScreenAndContinue();   
        //                break;
        //        }
        //    }
        //}

        //public static void BuyOrCancel(IProduct product)
        //{
        //    Console.Clear();
        //    Console.Write("Tryck [j] för att genomföra köpet eller annan bokstav för att avbryta: ");

        //    if (Console.ReadKey().Key == ConsoleKey.J)
        //    {
        //        Console.Clear();
        //        product.Buy();
        //        product.Use();
        //        ClearScreenAndContinue();
        //    }
        //    else
        //    {
        //        Console.Clear();
        //        return;
        //    }
        //}

        public static string CustomerInput()
        {
            bool inputLoop = true;
            string input = String.Empty;

            while (inputLoop)
            {
                input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.Write("\nDu måste ange ett alternativ: ");
                }
                else
                {
                    inputLoop = false;
                }
            }

            return input;
        }

        public static void ClearScreenAndContinue()
        {
            Console.Write("\nTryck på valfri tangent för att fortsätta. \n");
            Console.ReadKey();
            Console.Clear();
        }

        public static void WrongInputInfo() 
        {
            Console.Write("\nFelaktig inmatning.");
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }
    }
}
