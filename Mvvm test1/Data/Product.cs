using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Product
{
    public string ProductArticleNumber { get; set; } = null!;

    public int ProductIdname { get; set; }

    public string ProductDescription { get; set; } = null!;

    public int ProductIdcategory { get; set; }

    public string ProductPhoto { get; set; } = null!;

    public int ProductIdmanufacturer { get; set; }

    public decimal ProductCost { get; set; }

    public sbyte? ProductDiscountAmount { get; set; }

    public int ProductQuantityInStock { get; set; }

    public string ProductStatus { get; set; } = null!;

    public int? ProductIdunit { get; set; }

    public int? ProductIdprovider { get; set; }

    public virtual ICollection<Orderproduct> Orderproducts { get; } = new List<Orderproduct>();

    public virtual Productcategory ProductIdcategoryNavigation { get; set; } = null!;

    public virtual Productmanufacturer ProductIdmanufacturerNavigation { get; set; } = null!;

    public virtual Productname ProductIdnameNavigation { get; set; } = null!;

    public virtual Productprovider? ProductIdproviderNavigation { get; set; }

    public virtual Productunit? ProductIdunitNavigation { get; set; }

}
