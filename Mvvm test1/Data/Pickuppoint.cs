using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Pickuppoint
{
    public int IdPickUpPoint { get; set; }

    public int? Index { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? House { get; set; }

    public virtual ICollection<Ordername> Ordernames { get; } = new List<Ordername>();
}
