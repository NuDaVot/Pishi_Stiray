using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Producttype
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public double DefectedPercent { get; set; }
}
