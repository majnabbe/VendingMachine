using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Wallet
    {
        //public Dictionary<string, int> UserWallet { get; set; }
        public Dictionary<int, int> UserWallet { get; set; }
        public int InsertedMoney { get; set; } = 0;

        public Wallet()
        {
            //UserWallet.Add("enkronor", 10);
            //UserWallet.Add("femkronor", 10);
            //UserWallet.Add("tiokronor", 10);
            //UserWallet.Add("tjugolappar", 0);
            //UserWallet.Add("femtiolappar", 0);
            //UserWallet.Add("hundralappar", 0);

            // De olika valörerna och dess antal.
            UserWallet = new Dictionary<int, int>() 
            { 
                { 1, 10 },
                { 5, 10 },
                { 10, 10 },
                { 20, 0 },
                { 50, 0 },
                { 100, 0 }
            };
        }

        public void TotalAmountOfInsertedMoney()
        {
            //InsertMoney += 
        }

        public void CheckWallet(Wallet wallet)
        {
            if (wallet.UserWallet.Any(x => x.Value.Equals(0)))
            {
                Console.WriteLine("Valörens antal är 0.");
            }
        }

        public static void InsertMoney()
        {
            Wallet newWallet = new Wallet();

            bool menuLoop = true;

            // För korrekt utskrift (jfr if-satsen nedan).
            string coinOrNote = "mynt";

            while (menuLoop)
            {
                Console.WriteLine("\nPlånboken innehåller\n");
                foreach (KeyValuePair<int, int> item in newWallet.UserWallet)
                {
                    if (item.Key >= 20) coinOrNote = "sedlar";

                    Console.WriteLine($"{item.Value} st. {item.Key}-kronors {coinOrNote}.");
                }

                Console.WriteLine("Välj valör att mata in:\n1. En enkrona\n2. En femkrona\n3. En tiokrona\n4. En tjugolapp\n5. En femtiolapp\n6. En hundralapp\n----------------\n7. Klar\n");
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
                        break;
                    case "2":
                        if (newWallet.UserWallet[5] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[5] -= 1;
                        break; 
                    case "3":
                        if (newWallet.UserWallet[10] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[10] -= 1;
                        break; 
                    case "4":
                        if (newWallet.UserWallet[20] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[20] -= 1;
                        break;
                    case "5":
                        if (newWallet.UserWallet[50] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[50] -= 1;
                        break; 
                    case "6":
                        if (newWallet.UserWallet[100] == 0)
                        {
                            Console.WriteLine("Slut på valören.");
                            break;
                        }
                        newWallet.UserWallet[100] -= 1;
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
