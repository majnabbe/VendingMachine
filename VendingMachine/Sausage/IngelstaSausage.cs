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
            Console.WriteLine($"Köper {Name}.");
        }

        public void Description()
        {
            Console.Clear();
            Console.WriteLine($"Beskrivning: {ProductDescription}");
        }

        public void Use()
        {
            Console.WriteLine($"\nSmakar försiktigt på {Name}.");
        }
    }
}
