using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_Producto
{
    public int intProducto { get; set; }

    public string strDescripcion { get; set; } = null!;

    public int intTipoProducto { get; set; }

    public string? strTipoProducto { get; set; }

    public int intPresentacion { get; set; }

    public string? strPresentacion { get; set; }
}
