using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public sealed class Wallet
    {
        // Singelton
        private static readonly Wallet instance = new Wallet();
        public Dictionary<int, int> UserWallet { get; set; }
        public int TotalAmountInserted { get; set; }

        private Wallet()
        {
            // De olika valörerna och dess summa.
            UserWallet = new Dictionary<int, int>() 
            { 
                { 1, 10 },
                { 5, 50 },
                { 10, 100 },
                { 20, 0 },
                { 50, 0 },
                { 100, 0 }
            };

            TotalAmountInserted = 0;
        }

        public static Wallet GetWallet() 
        {
            return instance;
        }

        public void TotalAmountOfInsertedMoney(int money)
        {
            TotalAmountInserted += money;

            Console.WriteLine($"Inmatat belopp: {TotalAmountInserted} kr.\n");
        }


        public static void InsertMoney()
        {
            var newWallet = Wallet.GetWallet();

            bool menuLoop = true;

            // För korrekt utskrift (jfr if-satsen nedan).
            string coinOrNote = "mynt";

            while (menuLoop)
            {
                Console.WriteLine("\nPlånboken innehåller: \n");
                foreach (KeyValuePair<int, int> item in newWallet.UserWallet)
                {
                    if (item.Key >= 20) coinOrNote = "sedlar";

                    Console.WriteLine($"{item.Value} kr i {item.Key}-kronors{coinOrNote}.");
                }

                Console.WriteLine("\nVälj valör att mata in:\n1. En enkrona\n2. En femkrona\n3. En tiokrona\n4. En tjugolapp\n5. En femtiolapp\n6. En hundralapp\n----------------\n7. Klar\n");
                Console.Write("Ditt val: ");

                string userChoice = UtilityMethods.CustomerInput();

                switch (userChoice)
                {
                    case "1":
                        if (newWallet.UserWallet[1] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[1] -= 1;
                        newWallet.TotalAmountOfInsertedMoney(1);
                        break;
                    case "2":
                        if (newWallet.UserWallet[5] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[5] -= 5;
                        newWallet.TotalAmountOfInsertedMoney(5);
                        break; 
                    case "3":
                        if (newWallet.UserWallet[10] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[10] -= 10;
                        newWallet.TotalAmountOfInsertedMoney(10);
                        break; 
                    case "4":
                        if (newWallet.UserWallet[20] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[20] -= 20;
                        newWallet.TotalAmountOfInsertedMoney(20);
                        break;
                    case "5":
                        if (newWallet.UserWallet[50] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[50] -= 50;
                        newWallet.TotalAmountOfInsertedMoney(50);
                        break; 
                    case "6":
                        if (newWallet.UserWallet[100] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[100] -= 100;
                        newWallet.TotalAmountOfInsertedMoney(100);
                        break;
                    case "7":
                        menuLoop = false;
                        break;
                    //default:
                    //    UtilityMethods.WrongInputInfo();
                    //    break;
                }
            }
        }
    }
}
