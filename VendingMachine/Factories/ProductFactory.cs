using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Factories;
using VendingMachine.Ham;
using VendingMachine.MulledWine;
using VendingMachine.Sausage;

namespace VendingMachine
{
    public abstract class ProductFactory
    {
        // Del av abstract factory. Switch:en väljer produktkategori.

        public abstract IProduct GetProduct(string productType);

        public static ProductFactory CreateProductFactory(string factoryType)
        {
            ProductFactory factory = null;

            switch (factoryType)
            {
                case "1":
                    factory = new HamFactory();
                    break;
                case "2":
                    factory = new MulledWineFactory();
                    break;
                case "3":
                    factory = new SausageFactory();
                    break;
            }

            return factory;
        }
    }
}
