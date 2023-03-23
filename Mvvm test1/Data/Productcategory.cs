using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Productcategory
{
    public int ProductIdcategory { get; set; }

    public string? ProductNameCategoryl { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
