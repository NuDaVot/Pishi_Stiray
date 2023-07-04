using Mvvm_test1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Mvvm_test1
{
    public class ProductTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is ProductView productView)
            {
                // Implement your logic to select the template based on the type or properties of the ProductView
                // For now, we will use the default template for all items
                return DefaultTemplate;
            }

            return null;
        }
    }
}
