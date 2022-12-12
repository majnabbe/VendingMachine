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
        // Hjälpmetoder som används på flera ställen i programmet.

        // Kontrollerar om inmatning har skett.
        public static string CustomerInput()
        {
            bool inputLoop = true;
            string? input = String.Empty;

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

        // Pausar programmet och rensar skärmen.
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

        // Har egen metod ifall ändringar sker.
        public static void ClearConsole()
        {
            Console.Clear();
        }
    }
}
