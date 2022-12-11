using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class PrintMenu
    {
        public static void StartMenu()
        {
            Console.WriteLine("***** Varuautomat *****\n");

            Console.WriteLine("Välj produktkategori:\n\n1. Skinka\n2. Glögg\n3. Prinskorv\n----------------\n4. Avsluta\n");
            Console.Write("Ditt val: ");
        }

        public static void SelectedProductMenu(ProductInformation info)
        {
            Console.WriteLine($"Kategori: {info.Category}\nNamn: {info.Name}\nPris: {info.Price} kr");

            Console.WriteLine("\n1. Visa beskrivning\n2. Mata in pengar\n3. Köp\n ----------------\n4. Återgå.\n");
            Console.Write("Ditt val: ");
        }

        public static void BuyOrCancelMenu()
        {
            Console.Write("Tryck [k] för att genomföra köpet eller annan bokstav för att avbryta: ");
        }

        public static void HamMenu()
        {
            Console.WriteLine("Välj skinka:\n\n1. Jakobsdals julskinka\n2. Nybergs Deli Julskinka\n3. Scan julskinka\n----------------\n4. Återgå\n");
            Console.Write("Ditt val: ");
        }

        public static void MulledWineMenu()
        {
            Console.WriteLine("Välj glögg:\n\n1. Blossa\n2. Dufvenkrooks\n3. Saturnus\n----------------\n4. Återgå\n");
            Console.Write("Ditt val: ");
        }

        public static void SausageMenu()
        {
            Console.WriteLine("Välj prinskorv:\n\n1. Härryda Karlssons prinskorv\n2. Ingelsta kalkonprinskorv\n3. Scan prinskorv\n----------------\n4. Återgå\n");
            Console.Write("Ditt val: ");
        }  
    }
}
