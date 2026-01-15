using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viw_TanquesProducto
{
    public int intTanque { get; set; }

    public int? intProducto { get; set; }

    public string? strProducto { get; set; }

    public string? strFolioPemex { get; set; }
}
