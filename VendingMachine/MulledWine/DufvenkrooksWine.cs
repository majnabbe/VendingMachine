using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.MulledWine
{
    public class DufvenkrooksWine : ProductInformation, IProduct
    {
        // Produkt. Ärver av den abstrakta klassen och interfacet.

        public override string Category { get { return "Glögg"; } }
        public override string Name { get { return "Dufvenkrooks ekologiska glögg"; } }
        public override string ProductDescription { get { return "En ekologisk glögg med 2,25 % alkohol. Volym 750 ml."; } }
        public override int Price { get { return 32; } }

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
            Console.WriteLine($"\nVärmer {Name} i en kastrull.");
        }
    }
}
