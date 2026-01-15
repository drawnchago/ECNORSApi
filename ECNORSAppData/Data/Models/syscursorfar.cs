using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class syscursorfar
{
    public string strat { get; set; } = null!;

    public string id { get; set; } = null!;

    public string objectid { get; set; } = null!;

    public string? rvalue { get; set; }

    public string? rlvalue { get; set; }

    public string? value { get; set; }

    public string? lvalue { get; set; }

    public double? version { get; set; }
}
