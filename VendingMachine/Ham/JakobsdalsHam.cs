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
        public override int Price { get { return 139; } }

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
            Console.WriteLine($"\nSätter in {Name} i ugnen.");
        }
    }
}
