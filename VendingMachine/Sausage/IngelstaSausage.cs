using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Sausage
{
    public class IngelstaSausage : ProductInformation, IProduct
    {
        public override string Category { get { return "Prinskorv"; } }
        public override string Name { get { return "Ingelsta kalkonprinskorv"; } }
        public override string ProductDescription { get { return "Kalkonprinskorv av svensk fågel. Vikt 320g."; } }
        public override int Price { get { return 57; } }

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
            Console.WriteLine($"\nTar en tugga av {Name}.");
        }
    }
}
