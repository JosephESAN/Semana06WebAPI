using System;
using System.Collections.Generic;

namespace Semana06WebAPI.Data;

public partial class People
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public bool? IsActive { get; set; }
}
