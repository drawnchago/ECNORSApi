using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class syscursordate
{
    public int? id { get; set; }

    public int? objectid { get; set; }

    public string? property { get; set; }

    public string? value { get; set; }

    public string? lvalue { get; set; }

    public int? version { get; set; }
}
