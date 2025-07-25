﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
              return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                +" (Taxa de importação: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                +")";
        }
    }
}
