using DevExpress.Mvvm;
using Mvvm_test1.Model;
using Mvvm_test1.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mvvm_test1.ViewModel
{
    class BasketVM : BindableBase
    {
        MainWimdowModel _mainWimdow;
        readonly ProductM _model = new ProductM();
        public string UserName => _model.Name;
        public DelegateCommand<string> GoBack { get; set; }
        public ObservableCollection<ProductView> Product { get; set; } 
        public ProductView SelectedProduct { get; set; }
        public string Selectedpoint { get; set; }
        Trade3Context trade3Context = new Trade3Context();
        public BasketVM() 
        {
            GoBack = new DelegateCommand<string>(str =>
            {
                _model.GoBack();
            });
            _mainWimdow = MainWimdowViewModel._metod;
            Product  = ProductVM.productViews;
            Trade3Context trade3Context = new Trade3Context();
            foreach(Pickuppoint pickuppoint in trade3Context.Pickuppoints.ToList())
            {
                string s = $"{pickuppoint.IdPickUpPoint}. {pickuppoint.City}, {pickuppoint.Street}, д.{pickuppoint.House} ";
                point.Add(s);
            }
            TextBlock_Main = 0;
            Da();
            Selectedpoint = point[0];
        }
        public DelegateCommand<object> DeleteToCartCommand => new DelegateCommand<object>(obj =>
        {
            MessageBox.Show($"Товар удален из корзины: {SelectedProduct.product.ProductIdnameNavigation.ProductName1}");
            ProductVM.productViews.Remove(SelectedProduct);
            Product = null;
            Product =  ProductVM.productViews;
            Da();
            RaisePropertiesChanged("Product");
            MessageBox.Show((Selectedpoint[0]).ToString());
            if (Product.Count == 0)
            {
                _mainWimdow.Navipage("ProductsPage.xaml");
            }
        });
        public DelegateCommand ProductGO => new(() =>
        {
            _mainWimdow.Navipage("ProductsPage.xaml");
        });
        private void Da()
        {
            foreach(ProductView productView in Product)
            {
                TextBlock_Main += (Double)productView.product.ProductCost;
                Skid += Math.Round((Double)productView.product.ProductCost - (Double)productView.NewCost, 2);
            }
            RaisePropertiesChanged("TextBlock_Main");
            RaisePropertiesChanged("Skid");
        }
        public double TextBlock_Main { get; set; }
        public double Skid { get; set; }
        public List<string> point { get; set; } = new List<string>();
        public DelegateCommand Zaccaz => new(() =>
        {
            trade3Context.Ordernames.Add(new Ordername
            {
                OrderId = trade3Context.Ordernames.Max(x => x.OrderId) + 1,
                OrderStatus = "Новый",
                OrderDate = DateTime.Now,
                OrderDeliveryDate = DateTime.Now.AddYears(3),
                OrderPickupPoint = int.Parse(Selectedpoint[0].ToString()),
                Fioclient = "",
                OrderReceive = trade3Context.Ordernames.Max(x => x.OrderReceive) + 1,

            }) ;
            trade3Context.SaveChanges();
            foreach (ProductView productView in Product)
            {
                MessageBox.Show(productView.product.ProductIdnameNavigation.ProductName1.ToString());
                trade3Context.Orderproducts.Add(new Orderproduct
                {
                    OrderId = trade3Context.Ordernames.Max(x => x.OrderId),
                    ProductArticleNumber = productView.product.ProductArticleNumber,
                    ProductCount = Product.Count(n => n == productView),

                });
                trade3Context.SaveChanges();
            }
        });
    }
}
