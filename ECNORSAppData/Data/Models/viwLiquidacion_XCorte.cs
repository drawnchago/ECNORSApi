using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_XCorte
{
    public long intFolioLiquidacion { get; set; }

    public long? intFolioCorte { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public int? id { get; set; }

    public string? value { get; set; }

    public double? Precio { get; set; }
}
