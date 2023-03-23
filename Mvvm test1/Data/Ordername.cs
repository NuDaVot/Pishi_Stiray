using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Ordername
{
    public int OrderId { get; set; }

    public string OrderStatus { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public DateTime OrderDeliveryDate { get; set; }

    public int OrderPickupPoint { get; set; }

    public string? Fioclient { get; set; }

    public int? OrderReceive { get; set; }

    public virtual Pickuppoint OrderPickupPointNavigation { get; set; } = null!;

    public virtual ICollection<Orderproduct> Orderproducts { get; } = new List<Orderproduct>();
}
