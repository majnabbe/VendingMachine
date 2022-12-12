using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ham
{
    public class NybergsHam : ProductInformation, IProduct
    {
        // Produkt. Ärver av den abstrakta klassen och interfacet.

        public override string Category { get { return "Skinka"; } }
        public override string Name { get { return "Nybergs Deli julskinka"; } }
        public override string ProductDescription { get { return "Kokt julskinka med svål. Vikt ca 1 kg."; } }
        public override int Price { get { return 55; } }

        // Kontrollerar om tillräckligt med pengar har matats in för att genomföra köpet. Avbryter om så inte är fallet, annars
        // genomförs köpet och produkten används.
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

        // Produktbeskrivning.
        public void Description()
        {
            Console.Clear();
            Console.WriteLine($"Beskrivning: {ProductDescription}");
        }

        // Produktanvändning.
        public void Use()
        {
            Console.WriteLine($"\nGår hem och lägger in {Name} i kylen.");
        }
    }
}
