using System;
using System.Collections.Generic;

namespace Semana06WebAPI.Data;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }
}
