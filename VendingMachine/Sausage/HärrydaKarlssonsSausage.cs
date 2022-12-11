using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Sausage
{
    public class HärrydaKarlssonsSausage : ProductInformation, IProduct
    {
        public override string Category { get { return "Prinskorv"; } }
        public override string Name { get { return "Härryda Karlssons prinskorv"; } }
        public override string ProductDescription { get { return "Skinnfri prinskorv. Vikt 300 g. "; } }
        public override int Price { get { return 38; } }

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
            Console.WriteLine($"\nSteker {Name}.");
        }
    }
}
