using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_Productos_AditYLub
{
    public int intProducto { get; set; }

    public string strDescripcion { get; set; } = null!;

    public string strProducto { get; set; } = null!;

    public int intTipoProducto { get; set; }

    public string? strTipoProducto { get; set; }

    public int intPresentacion { get; set; }

    public string? strPresentacion { get; set; }

    public string? strCodigoBarras { get; set; }
}
