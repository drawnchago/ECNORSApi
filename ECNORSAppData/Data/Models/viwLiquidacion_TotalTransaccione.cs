using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalTransaccione
{
    public long intFolioCorte { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public double? Litros { get; set; }

    public double? Importe { get; set; }
}
