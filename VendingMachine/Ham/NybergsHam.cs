using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ham
{
    public class NybergsHam : ProductInformation, IProduct
    {
        public override string Category { get { return "Skinka"; } }
        public override string Name { get { return "Nybergs Deli julskinka"; } }
        public override string ProductDescription { get { return "Kokt julskinka med svål. Vikt ca 2 kg."; } }
        public override decimal Price { get { return 118; } }

        public void Buy()
        {
            Console.WriteLine($"Köper {Name}.");
        }

        public void Description()
        {
            Console.Clear();
            Console.WriteLine($"Beskrivning: {ProductDescription}");
        }

        public void Use()
        {
            Console.WriteLine($"\nLägger in {Name} i kylen.");
        }
    }
}
