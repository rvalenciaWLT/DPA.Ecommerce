using System;
using System.Collections.Generic;

namespace DPA.Ecommerce.API;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }
}
