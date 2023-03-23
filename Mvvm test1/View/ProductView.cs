using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_test1.View
{
    public class ProductView
    {
        public string Brash_discond { get; set; } = "#FF498C51";
        public string ProductPhoto { get; set; } = $"\\Resources\\Image\\A346R4.jpg";
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductManufacturer { get; set; }
        public double ProductCost { get; set; }
        public double ProductCostDiscount { get; set; }

        public ProductView( string productName, string productDescription, string productManufacturer, double productCost, double productCostDiscount, string productphoto = "picture.png")
        {
            if (productCostDiscount > 10 && productCostDiscount <= 15)
                Brash_discond = "#e1df44";
            else if (productCostDiscount > 15 && productCostDiscount <= 25)
                Brash_discond = "#e19244";
            else if (productCostDiscount > 25 && productCostDiscount <= 30)
                Brash_discond = "#e14444";
            else  Brash_discond = "#FF498C51";

            ProductPhoto = $"\\Resources\\Image\\{productphoto}"; 
            ProductName = productName;
            ProductDescription = productDescription;
            ProductManufacturer = productManufacturer;
            ProductCost = productCost;
            ProductCostDiscount = productCostDiscount;
        }
    }
}
