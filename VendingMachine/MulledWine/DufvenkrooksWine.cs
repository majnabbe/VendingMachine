using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.MulledWine
{
    public class DufvenkrooksWine : ProductInformation, IProduct
    {
        public override string Category { get { return "Glögg"; } }
        public override string Name { get { return "Dufvenkrooks ekologiska glögg"; } }
        public override string ProductDescription { get { return "En ekologisk glögg med 2,25 % volymprocent alkohol. Volym 750 ml."; } }
        public override decimal Price { get { return 32; } }

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
            Console.WriteLine($"\nVärmer {Name} i en kastrull.");
        }
    }
}
