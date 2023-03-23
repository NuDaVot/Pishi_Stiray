using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using Mvvm_test1.View;

namespace Mvvm_test1.Model
{
    class MainWimdowModel : BindableBase
    {
        private string _namePage = /*"Products.xaml"*/ 
            "SignInPage.xaml";
        public string NamePage;
        public MainWimdowModel()
        {
             NamePage = _namePage;
        }
        public void Navipage(string vlue) 
        {
            NamePage = vlue;
            RaisePropertiesChanged("NamePage");
        }
    }
}
