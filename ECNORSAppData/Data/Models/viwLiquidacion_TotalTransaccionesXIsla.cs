using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalTransaccionesXIsla
{
    public long? intFolioCorte { get; set; }

    public int? intTurno { get; set; }

    public int? intIsla { get; set; }

    public int? intProducto { get; set; }

    public double? Litros { get; set; }

    public double? Importe { get; set; }

    public double? dblPrecioUnitario { get; set; }
}
