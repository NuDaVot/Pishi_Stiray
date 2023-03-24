using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using Mvvm_test1.Model;
using Mvvm_test1.View;

namespace Mvvm_test1.ViewModel
{
    class ProductVM : BindableBase
    {
        readonly ProductM _model = new ProductM() ;
        
        public ProductVM()
        {
            _model.PropertyChanged += (e, s) => RaisePropertiesChanged(s.PropertyName);
            GoBack = new DelegateCommand<string>(str =>
            {
                _model.GoBack();
            });
            Sort = new DelegateCommand<string>(str =>
            {
                _model.Sort();
            });
            _model.GetProducts();
            TestCommand = new DelegateCommand<string>(str =>
            {
                //var pr = (Product)sender;
                //MessageBox.Show(this.Product);
            });

        }
        public string UserName => _model.Name;
        public DelegateCommand<string> GoBack { get; set; }
       

        public List<ProductView> Product => _model.Products;
        public string ProductIdname => _model.Name;


        public string Search {
            get
            {
               
                return GetValue<string>();
            }
            set {
                SetValue<string>(value);
                _model.Search(value);
                //_model.Search(value);

            } 
        }
        public string  Filter
        {
            //get
            //{
            //    return GetValue<string>();
            //}
            set
            {
                SetValue<string>(value);
                _model.Filter(value);
            }
        }
        public string NameSort => _model.NameSort;
        public DelegateCommand<string> Sort { get; set; }
        public string Count => _model.Count;
        public DelegateCommand<string> TestCommand { get; }
    }
}
