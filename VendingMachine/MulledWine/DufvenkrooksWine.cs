﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.MulledWine
{
    public class DufvenkrooksWine : ProductInformation, IProduct
    {
        public override string Category => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override string ProductDescription => throw new NotImplementedException();

        public override decimal Price => throw new NotImplementedException();

        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Description()
        {
            throw new NotImplementedException();
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}