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
        public override string Name { get { return "Blossa"; } }
        public override string ProductDescription { get { return "en beskrivning av Blossa."; } }
        public override decimal Price { get { return 100; } }

        public override void Buy()
        {
            Console.WriteLine($"\nKöper {Name}.");
            //throw new NotImplementedException();
        }

        public override void Description()
        {
            Console.Clear();
            Console.WriteLine($"\nHär följer {ProductDescription}");
            //throw new NotImplementedException();
        }

        public override void Use()
        {
            Console.WriteLine($"\nSveper {Name}.");
            //throw new NotImplementedException();
        }
    }
}
