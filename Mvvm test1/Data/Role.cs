﻿using System;
using System.Collections.Generic;

namespace Mvvm_test1;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
