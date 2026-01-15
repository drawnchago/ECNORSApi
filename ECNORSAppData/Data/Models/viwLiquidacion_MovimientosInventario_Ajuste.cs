using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_MovimientosInventario_Ajuste
{
    public string? strReferencia { get; set; }

    public long intSecuencia { get; set; }

    public int? intProducto { get; set; }

    public string? strProducto { get; set; }

    public string? strMovimiento { get; set; }

    public double? dblCantidad { get; set; }

    public DateTime? datFecha { get; set; }

    public string? strCapturo { get; set; }

    public string? strCausa { get; set; }

    public int? intSigno { get; set; }
}
