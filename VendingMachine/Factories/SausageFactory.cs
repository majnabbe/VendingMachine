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

            Dictionary<string, IProduct> sausage = new Dictionary<string, IProduct>();

            sausage.Add("1", new HärrydaKarlssonsSausage());
            sausage.Add("2", new IngelstaSausage());
            sausage.Add("3", new ScanSausage());

            return sausage[sausageType];
        }
    }
}
