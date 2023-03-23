using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Productmanufacturer
{
    public int ProductIdmanufacturer { get; set; }

    public string? ProductNameManufacturer { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
