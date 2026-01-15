using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalXLiquidar
{
    public long? intFolioCorte { get; set; }

    public int? intIsla { get; set; }

    public int? intProducto { get; set; }

    public double dblVolumen { get; set; }

    public double? dblImporte { get; set; }

    public double? dblPrecioUnitario { get; set; }
}
