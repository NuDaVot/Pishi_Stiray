using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Orderproduct
{
    public int OrderId { get; set; }

    public string ProductArticleNumber { get; set; } = null!;

    public int? ProductCount { get; set; }

    public virtual Ordername Order { get; set; } = null!;

    public virtual Product ProductArticleNumberNavigation { get; set; } = null!;
}
