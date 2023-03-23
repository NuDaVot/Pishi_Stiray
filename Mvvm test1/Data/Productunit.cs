using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Productunit
{
    public int ProductIdunit { get; set; }

    public string? ProductNameUnitl { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
