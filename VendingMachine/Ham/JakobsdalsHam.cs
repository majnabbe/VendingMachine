using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ham
{
    public class JakobsdalsHam : ProductInformation, IProduct
    {
        public override string Category { get { return "Skinka"; } }
        public override string Name { get { return "Jakobsdals julskinka"; } }
        public override string ProductDescription { get { return "Senapsgriljerad julskinka. Vikt 0,8 kg."; } }
        public override int Price { get { return 129; } }

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
            Console.WriteLine($"\nGår hem och sätter in {Name} i ugnen.");
        }
    }
}
