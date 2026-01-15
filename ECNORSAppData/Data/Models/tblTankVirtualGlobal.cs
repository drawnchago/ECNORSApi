using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTankVirtualGlobal
{
    public int intIdTanque { get; set; }

    public int? intIdProdcuto { get; set; }

    public string? strProducto { get; set; }

    public double? dblLitros { get; set; }
}
