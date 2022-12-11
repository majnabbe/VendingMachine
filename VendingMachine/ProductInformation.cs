using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class ProductInformation //: IProduct
    {
        public abstract string Category { get; }
        public abstract string Name { get; }
        public abstract string ProductDescription { get; }
        // Har valt int isället för decimal eftersom det bara handlas med hela kronor i uppgiften.
        public abstract int Price { get; }

        //// Implementerar inte interfacets metoder. Det sker i produktklasserna.
        //public abstract void Buy();

        //public abstract void Description();

        //public abstract void Use();
    }
}
