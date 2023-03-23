using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using Mvvm_test1.Model;

namespace Mvvm_test1.ViewModel
{
    class MainWimdowViewModel : BindableBase
    {
        static public MainWimdowModel _metod = new MainWimdowModel();
        public MainWimdowViewModel()
        {
            _metod.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
            ChangePage = new DelegateCommand<string>(str =>
            {
                _metod.Navipage(str);
            });
        }
        public string NamePage => _metod.NamePage;
        public DelegateCommand<string> ChangePage;
    }
}
