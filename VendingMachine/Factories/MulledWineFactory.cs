using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.MulledWine;

namespace VendingMachine
{
    public class MulledWineFactory : ProductFactory
    {
        public override IProduct GetProduct(string mulledWineType)
        {
            // Del av abstract factory. Dictionaryn lagrar menyval och produkt.

            Dictionary<string, IProduct> products = new Dictionary<string, IProduct>();

            products.Add("1", new BlossaWine());
            products.Add("2", new DufvenkrooksWine());
            products.Add("3", new SaturnusWine());

            return products[mulledWineType];
        }
    }
}
