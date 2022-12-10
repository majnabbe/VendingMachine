using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.MulledWine
{
    public class BlossaWine : ProductInformation, IProduct 
    {
        public override string Category { get { return "Glögg"; } }
        public override string Name { get { return "Blossa lättglögg"; } }
        public override string ProductDescription { get { return "En lättglögg med 2,2 % alkohol. Volym 750 ml."; } }
        public override decimal Price { get { return 29; } }

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
            Console.WriteLine($"\nSveper {Name}.");
        }
    }
}
