using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class ProductInfo
    { 
        public abstract string Category { get; }
        public abstract string Name { get; }
        public abstract string ProductDescription { get; }
        public abstract decimal Price { get; }
    }
}
