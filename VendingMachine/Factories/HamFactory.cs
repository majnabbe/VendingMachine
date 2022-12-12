using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ham;

namespace VendingMachine
{
    public class HamFactory : ProductFactory
    {
        public override IProduct GetProduct(string hamType)
        {
            // Del av abstract factory. Dictionaryn lagrar menyval och produkt.

            Dictionary<string, IProduct> products = new Dictionary<string, IProduct>();

            products.Add("1", new JakobsdalsHam());
            products.Add("2", new NybergsHam());
            products.Add("3", new ScanHam());

            return products[hamType];
        }
    }
}
