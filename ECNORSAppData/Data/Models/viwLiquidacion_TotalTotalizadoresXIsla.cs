using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalTotalizadoresXIsla
{
    public long intFolioCorte { get; set; }

    public int intIsla { get; set; }

    public int intProducto { get; set; }

    public double? Litros { get; set; }

    public double? Importe { get; set; }
}
