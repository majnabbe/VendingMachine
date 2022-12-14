using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Menus
    {
        // Samling av menyutskrifter och liknande. 
        public static void VendingMachineText()
        {
            Console.WriteLine("***** Varuautomat *****\n");
        }

        public static void StartMenu()
        {
            Console.WriteLine("Välj produktkategori:\n\n1. Skinka\n2. Glögg\n3. Prinskorv\n----------------\n4. Avsluta (returnerar eventuell växel)\n");
            Console.Write("Ditt val: ");
        }

        public static void SelectedProductMenu(ProductInformation info)
        {
            Console.WriteLine($"Kategori: {info.Category}\nNamn: {info.Name}\nPris: {info.Price} kr");

            Console.WriteLine("\n1. Visa beskrivning\n2. Mata in pengar\n3. Köp\n4. Växel tillbaka\n ----------------\n5. Återgå.\n");
            Console.Write("Ditt val: ");
        }

        public static void PrintDenominationUsedUp()
        {
            Console.WriteLine("Valören saknas.");

            UtilityMethods.ClearScreenAndContinue();
        }

        public static void PrintTotalAmountOfInsertedMoney()
        {
            Console.WriteLine($"Inmatat belopp: {Wallet.GetWallet().TotalAmountInserted} kr.\n");
        }

        public static void WalletMenu()
        {
            Console.WriteLine();

            PrintTotalAmountOfInsertedMoney();

            Console.WriteLine("Välj valör att mata in eller genomför köp:\n\n1. En enkrona\n2. En femkrona\n3. En tiokrona" +
                    "\n4. En tjugolapp\n5. En femtiolapp\n6. En hundralapp\n----------------\n7. Köp\n----------------\n8. Återgå\n");
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
