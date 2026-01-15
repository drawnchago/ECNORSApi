using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class syscursordat
{
    public int id { get; set; }

    public int? objectid { get; set; }

    public string property { get; set; } = null!;

    public string? value { get; set; }

    public string? uvalue { get; set; }

    public string? lvalue { get; set; }

    public int version { get; set; }
}
