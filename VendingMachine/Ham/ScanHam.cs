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
        public override string ProductDescription { get { return "Rimmad julskinka. Vikt ca 1 kg."; } }
        public override int Price { get { return 110; } }

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
            Console.WriteLine($"\nGrisfestar med {Name}.");
        }
    }
}
