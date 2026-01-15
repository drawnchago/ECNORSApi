using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class syscursorpar
{
    public bool? xon { get; set; }

    public bool? xor { get; set; }

    public bool? sem { get; set; }

    public int? plevel { get; set; }

    public int? mmnr { get; set; }

    public int? mmxr { get; set; }

    public int? histd { get; set; }

    public int? erbef { get; set; }
}
