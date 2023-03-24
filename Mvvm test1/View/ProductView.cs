using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mvvm_test1.View
{
    public class ProductView
    {
        public Product product { get; set; }
        public string Brash_discond {get; set; }
        public decimal? NewCost
        {
            get
            {
                if (product.ProductDiscountAmount != 0)
                    return product.ProductCost / 100 * (100 - product.ProductDiscountAmount);
                else
                    return null;
            }
        }

        public ProductView(Product product)
        {
            this.product = product;
            if (product.ProductDiscountAmount > 10 && product.ProductDiscountAmount <= 15)
                Brash_discond = "#e1df44";
            else if (product.ProductDiscountAmount > 15 && product.ProductDiscountAmount <= 25)
                Brash_discond = "#e19244";
            else if (product.ProductDiscountAmount > 25 && product.ProductDiscountAmount <= 30)
                Brash_discond = "#e14444";
            else Brash_discond = "#FF498C51";

        }

    }
}
