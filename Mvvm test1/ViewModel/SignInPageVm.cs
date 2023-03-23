using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using DevExpress.Mvvm;
using Mvvm_test1.Model;
using Mvvm_test1.View;
using static System.Net.Mime.MediaTypeNames;

namespace Mvvm_test1.ViewModel
{
    class SignInPageVm : BindableBase 
    {

        readonly SIgnInPageM _model = new SIgnInPageM();

        public string? loginTb { get; set; }
        public string? PasswordTb { get; set; }
        public SignInPageVm() 
        {
            _model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
            Sign_In = new DelegateCommand<string>(str =>
            {
                _model.IsDate(loginTb, PasswordTb);
            });
            Look = new DelegateCommand<string>(str =>
            {
                _model.IsDate();
            }); 
        }
        public DelegateCommand<string> Sign_In { get; }
        public DelegateCommand<string> Look { get;}
    }


}

