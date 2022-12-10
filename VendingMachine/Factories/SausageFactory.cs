using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Sausage;

namespace VendingMachine.Factories
{
    public class SausageFactory : ProductFactory
    {
        public override IProduct GetProduct(string sausageType)
        {
            //IProduct product = null; 

            Dictionary<string, IProduct> products = new Dictionary<string, IProduct>();

            products.Add("1", new HärrydaKarlssonsSausage());
            products.Add("2", new IngelstaSausage());
            products.Add("3", new ScanSausage());

            return products[sausageType];
        }
    }
}
