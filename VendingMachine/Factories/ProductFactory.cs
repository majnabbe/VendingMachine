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
        public abstract IProduct GetProduct(string productType);

        public static ProductFactory CreateProductFactory(string factoryType)
        {
            ProductFactory factory = null;

            switch (factoryType)
            {
                case "1":factory =  new HamFactory();
                    break;
                case "2": factory = new MulledWineFactory();
                    break;
                case "3": factory = new SausageFactory();
                    break;                  
            }

            return factory;


            //if (factoryType == "1")
            //{
            //    return new HamFactory();
            //}
            //else if (factoryType == "2")
            //{
            //    return new MulledWineFactory();
            //}
            //else
            //{
            //    return new SausageFactory();
            //}

        }



        //public static IProduct GetProduct(string productType)
        //{
        //    //IProduct product = null;

        //    Dictionary<string, IProduct> product = new Dictionary<string, IProduct>();

        //    product.Add("1", new JakobsdalsHam());
        //    product.Add("2", new NybergsHam());
        //    product.Add("3", new ScanHam());
        //    product.Add("4", new BlossaWine());
        //    product.Add("5", new DufvenkrooksWine());
        //    product.Add("6", new SaturnusWine());
        //    product.Add("7", new HärrydaKarlssonsSausage());
        //    product.Add("8", new IngelstaSausage());
        //    product.Add("9", new ScanSausage());

        //    return product[productType];
        //}

        // Använder den abstrakta klassen istället för interfacet för att samla bådas funktionalitet
        // under ett objekt.
        //public static ProductInformation GetProduct(string productType)
        //{
        //    IProduct product = null;

        //    Dictionary<string, ProductInformation> product = new Dictionary<string, ProductInformation>();

        //    product.Add("1", new JakobsdalsHam());
        //    product.Add("2", new NybergsHam());
        //    product.Add("3", new ScanHam());
        //    product.Add("4", new BlossaWine());
        //    product.Add("5", new DufvenkrooksWine());
        //    product.Add("6", new SaturnusWine());
        //    product.Add("7", new HärrydaKarlssonsSausage());
        //    product.Add("8", new IngelstaSausage());
        //    product.Add("9", new ScanSausage());

        //    return product[productType];
        //}





        //public static IProduct GetHam(string hamType)
        //{
        //    //IProduct product = null;

        //    Dictionary<string, IProduct> ham = new Dictionary<string, IProduct>();

        //    ham.Add("1", new JakobsdalsHam());
        //    ham.Add("2", new NybergsHam());
        //    ham.Add("3", new ScanHam());

        //    return ham[hamType];
        //}

        //public static IProduct GetMulledWine(string mulledWineType)
        //{
        //    //IProduct product = null;

        //    Dictionary<string, IProduct> mulledWine = new Dictionary<string, IProduct>();

        //    mulledWine.Add("1", new BlossaWine());
        //    mulledWine.Add("2", new DufvenkrooksWine());
        //    mulledWine.Add("3", new SaturnusWine());

        //    return mulledWine[mulledWineType];
        //}

        //public static IProduct GetSausage(string sausageType)
        //{
        //    //IProduct product = null;

        //    Dictionary<string, IProduct> sausage = new Dictionary<string, IProduct>();

        //    sausage.Add("1", new HärrydaKarlssonsSausage());
        //    sausage.Add("2", new IngelstaSausage());
        //    sausage.Add("3", new ScanSausage());

        //    return sausage[sausageType];
        //}
    }
}
