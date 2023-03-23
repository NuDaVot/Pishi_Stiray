using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Productprovider
{
    public int ProductIdprovider { get; set; }

    public string? ProductNameProvider { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
