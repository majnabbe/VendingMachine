using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.MulledWine
{
    public class SaturnusWine : ProductInformation, IProduct
    {
        public override string Category { get { return "Glögg"; } }
        public override string Name { get { return "Saturnus 1893 alkoholfri glögg"; } }
        public override string ProductDescription { get { return "En alkoholfri glögg. Innehåller sulfiter. Volym 750 ml."; } }
        public override decimal Price { get { return 30; } }

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
            Console.WriteLine($"\nHäller ut felköpet {Name}.");
        }
    }
}
