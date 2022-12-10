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
            //IProduct product = null;

            Dictionary<string, IProduct> ham = new Dictionary<string, IProduct>();

            ham.Add("1", new JakobsdalsHam());
            ham.Add("2", new NybergsHam());
            ham.Add("3", new ScanHam());

            return ham[hamType];
        }
    }
}
