using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Productname
{
    public int ProductIdname { get; set; }

    public string? ProductName1 { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
