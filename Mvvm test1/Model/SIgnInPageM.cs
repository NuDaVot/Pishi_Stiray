using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using Mvvm_test1.ViewModel;

namespace Mvvm_test1.Model
{
    class SIgnInPageM : BindableBase
    {

        private readonly Trade3Context _tradeContext = new Trade3Context();
        private readonly string _login = "";
        public string? Login;

        private readonly string _password = "";
        public string? Password;

        MainWimdowModel _mainWimdow;

        public SIgnInPageM()
        {
            Login = _login;
            Password = _password;
            _mainWimdow = MainWimdowViewModel._metod;
        }
        public void IsDate(string Login, string Password) 
        {
            if (Login != null && Password != null) 
            {
                var user = _tradeContext.Users.First(p => p.UserLogin == Login);
                if (user != null)
                {
                    if (user.UserPassword.Equals(Password))
                    {
                        MessageBox.Show("Da");
                        _mainWimdow.Navipage("ProductsPage.xaml");
                        ProductM.User = user;
                    }
                    else { MessageBox.Show("Не верный пароль"); }
                }
                else { MessageBox.Show("Пользователь не найден"); }
            }
            else { MessageBox.Show("Что-то пусто"); }
        }
        public void IsDate()
        {
            _mainWimdow.Navipage("ProductsPage.xaml");
            ProductM.User = null;
        }
    }
}
