using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ham
{
    public class ScanHam : ProductInformation, IProduct
    {
        public override string Category { get { return "Skinka"; } }
        public override string Name { get { return "Scan julskinka"; } }
        public override string ProductDescription { get { return "Rimmad julskinka. Vikt ca 0,5 kg."; } }
        public override int Price { get { return 55; } }

        public void Buy()
        {
            if (!Wallet.GetWallet().CheckAmount(Price))
            {
                Console.WriteLine("Du har ej matat in tillräckligt med pengar.");

                UtilityMethods.ClearScreenAndContinue();

                return;
            }

            Wallet.GetWallet().MoneyLeftAfterPurchase(Price);

            Console.WriteLine($"Köper {Name}.");

            Use();

            UtilityMethods.ClearScreenAndContinue();
        }

        public void Description()
        {
            Console.Clear();
            Console.WriteLine($"Beskrivning: {ProductDescription}");
        }

        public void Use()
        {
            Console.WriteLine($"\nGrisfestar omedelbart med {Name}.");
        }
    }
}
