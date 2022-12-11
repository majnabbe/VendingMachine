using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Menus;

namespace VendingMachine
{
    public sealed class Wallet
    {
        // Singelton
        private static readonly Wallet instance = new Wallet();
        public Dictionary<int, int> UserWallet { get; set; }
        public int TotalAmountInserted { get; set; }
        public bool EnoughMoneyInserted { get; set; }

        private Wallet()
        {
            // De olika valörerna och deras summa.
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

        // Beräknar hur mycket pengar som matats in.
        public void TotalAmountOfInsertedMoney(int money)
        {
            TotalAmountInserted += money;
        }

        // Beräknar hur mycket pengar som är kvar efter ett köp.
        public void MoneyLeftAfterPurchase(int price)
        {
            TotalAmountInserted -= price;
        }

        // Beräknar hur mycket växel som ska returneras och i vilka valörer.
        public void CalculateChange(int amount)
        {
            // Håller reda på hur många av varje valör som ska returneras.
            int counter = 0;

            Console.WriteLine($"\nVäxel tillbaka totalt {amount} kr: ");

            // Japp, en trippel-loop. Upphör när ingen växel finns kvar.
            while (amount != 0)
            {
                // Delar mängden pengar med de olika valörerna för att se vad som ska returneras. 
                // Loopen börjar med den högsta valören och om kvoten är minst 1 överstiger växeln
                // aktuell valör och kan återbetals som sådan.
                foreach (KeyValuePair<int, int> item in UserWallet.OrderByDescending(key => key.Key))
                {
                    while (amount / item.Key >= 1)
                    {
                        amount -= item.Key;

                        UserWallet[item.Key] += item.Key;

                        TotalAmountInserted = amount;

                        counter++;
                    }

                    if (counter >= 1)
                    {
                        Console.WriteLine($"\n{counter} st. mynt/sedlar á {item.Key} kr.");

                        counter = 0;
                    }
                }
            }
        }


        // Kollar om priset på produkten har uppnåtts.
        public bool CheckAmount(int price)
        {
            if (price >= TotalAmountInserted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     


        public void InsertMoney(IProduct product)
        {
            UtilityMethods.ClearConsole();

            var newWallet = Wallet.GetWallet();

            bool menuLoop = true;

            // För korrekt utskrift (jfr if-satsen nedan).
            string coinOrNote = String.Empty;

            while (menuLoop)
            {
                Console.WriteLine("Plånboken innehåller: \n");

                foreach (KeyValuePair<int, int> item in newWallet.UserWallet)
                {
                    if (item.Key >= 20) coinOrNote = "sedlar";
                    else coinOrNote = "mynt";

                    Console.WriteLine($"{item.Value} kr i {item.Key}-kronors{coinOrNote}.");
                }

                //Console.WriteLine($"\nInmatat belopp: {newWallet.TotalAmountInserted} kr.");

                //Console.WriteLine("\nVälj valör att mata in:\n\n1. En enkrona\n2. En femkrona\n3. En tiokrona" +
                //    "\n4. En tjugolapp\n5. En femtiolapp\n6. En hundralapp\n----------------\n7. Köp\n----------------\n8. Återgå\n");
                //Console.Write("Ditt val: ");

                PrintMenu.WalletMenu();

                string userChoice = UtilityMethods.CustomerInput();

                UtilityMethods.ClearConsole();

                switch (userChoice)
                {
                    case "1":
                        if (newWallet.UserWallet[1] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[1] -= 1;
                        newWallet.TotalAmountOfInsertedMoney(1);
                        break;
                    case "2":
                        if (newWallet.UserWallet[5] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[5] -= 5;
                        newWallet.TotalAmountOfInsertedMoney(5);
                        break;
                    case "3":
                        if (newWallet.UserWallet[10] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[10] -= 10;
                        newWallet.TotalAmountOfInsertedMoney(10);
                        break;
                    case "4":
                        if (newWallet.UserWallet[20] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[20] -= 20;
                        newWallet.TotalAmountOfInsertedMoney(20);
                        break;
                    case "5":
                        if (newWallet.UserWallet[50] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[50] -= 50;
                        newWallet.TotalAmountOfInsertedMoney(50);
                        break;
                    case "6":
                        if (newWallet.UserWallet[100] == 0)
                        {
                            PrintMenu.PrintDenominationUsedUp();
                            break;
                        }
                        newWallet.UserWallet[100] -= 100;
                        newWallet.TotalAmountOfInsertedMoney(100);
                        break;
                    case "7":
                        BuyOrCancelMenu.Menu(product);
                        break;
                    case "8":
                        menuLoop = false;
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
