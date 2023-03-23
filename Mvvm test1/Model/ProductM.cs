using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using Mvvm_test1.View;
using Mvvm_test1.ViewModel;

namespace Mvvm_test1.Model
{
    class ProductM : BindableBase
    {
        MainWimdowModel _mainWimdow;
        private readonly Trade3Context _tradeContext = new Trade3Context();
        static public User? User { get; set; } = null;
        public string Name { get; set; }
        public string NameSort { get; set; } = "По возростанию";
        public string filter { get; set; } = "Все  диапазоны";
        public string Count { get; set; } 

        public List<ProductView> Products { get; set; }

        string search { get; set; } = null;

        public ProductM()
        {
            _mainWimdow = MainWimdowViewModel._metod;
            if (User != null)
            {
                Name = $"{User.UserSurname} {User.UserName} {User.UserPatronymic}";
            }
            else { Name = "Гость"; };
        }
        public void GoBack()
        {
            _mainWimdow.Navipage("SIgnInPage.xaml");
        }
        public void Sort() 
        {
            if(NameSort == "По возростанию")
            {
                NameSort = "По убыванию";
            }
            else
            {
                NameSort = "По возростанию";
            }
            GetProducts();
            RaisePropertiesChanged("NameSort");
        }
        public void Search(string value)
        {
            search = value;
            GetProducts();
        }
        public void Filter(string value)
        {
            filter = value;
            GetProducts();
        }
        public List<ProductView> GetViewProducts()
        {
            List<ProductView> products = new();
            var product = _tradeContext.Products.ToList();
            var productname = _tradeContext.Productnames.ToList();
            var manufacturer = _tradeContext.Productmanufacturers.ToList();
            for(int i = 0; i < product.Count; i++)
            {
                products.Add(
                    new ProductView(
                        product[i].ProductIdnameNavigation.ProductName1,
                        product[i].ProductDescription,
                        product[i].ProductIdmanufacturerNavigation.ProductNameManufacturer,
                        Convert.ToDouble(product[i].ProductCost),
                        Convert.ToDouble(product[i].ProductDiscountAmount),
                        product[i].ProductPhoto
                        )
                    ); ;
            }
            return products;
        }
        public void GetProducts() 
        {
            var products = GetViewProducts();
            Count = $"\\{products.Count}";
            //MessageBox.Show($"{products.Count}");
            if (!string.IsNullOrEmpty(search))
                products = products.Where(p => p.ProductDescription.ToLower().Contains(search.ToLower())).ToList();

            if (!string.IsNullOrEmpty(filter))
            {
                switch (filter)
                {
                    case "0-9,99%":
                        products = products.Where(p => p.ProductCostDiscount >= 0 && p.ProductCostDiscount < 5).ToList();
                        break;
                    case "10-14,99%":
                        products = products.Where(p => p.ProductCostDiscount >= 5 && p.ProductCostDiscount < 9).ToList();
                        break;
                    case "15% и более":
                        products = products.Where(p => p.ProductCostDiscount >= 9).ToList();
                        break;
                    default: break;
                }
            }

            if (!string.IsNullOrEmpty(NameSort))
            {
                switch (NameSort)
                {
                    case "По возрастанию":
                        products = products.OrderBy(p => p.ProductCost).ToList();
                        break;
                    case "По убыванию":
                        products = products.OrderByDescending(p => p.ProductCost).ToList();
                        break;
                }
                
            }
            Count = $"{products.Count}" + Count;
            RaisePropertiesChanged("Count");
            Products = null;
            Products = products;
            RaisePropertiesChanged("Product");
        }
        //public void GetNameProducts(string value)
        //{
        //    int ival = int.Parse(value);
        //    var ProductIdname = _tradeContext.Productnames.First(p => p.ProductIdname == ival);
        //    MessageBox.Show(ProductIdname.ProductName1);

        //    RaisePropertiesChanged("ProductIdname");
        //}

    }
}
