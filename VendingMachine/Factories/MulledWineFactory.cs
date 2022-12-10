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
            //IProduct product = null;

            Dictionary<string, IProduct> mulledWine = new Dictionary<string, IProduct>();

            mulledWine.Add("1", new BlossaWine());
            mulledWine.Add("2", new DufvenkrooksWine());
            mulledWine.Add("3", new SaturnusWine());

            return mulledWine[mulledWineType];
        }
    }
}
