using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_MovimientosInventario
{
    public int intMovimiento { get; set; }

    public int? intTipoMovimiento { get; set; }

    public string? strTipoMovimiento { get; set; }

    public string? strTM { get; set; }

    public int? intSigno { get; set; }

    public string? strDescripcion { get; set; }
}
