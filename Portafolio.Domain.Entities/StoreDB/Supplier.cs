﻿using System;
using System.Collections.Generic;

namespace Portafolio.Domain.Entities.StoreDB;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
