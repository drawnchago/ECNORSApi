using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_CapturaManualTransacciones_Producto
{
    public int? intUsuario { get; set; }

    public int? intDispensario { get; set; }

    public int? intProducto { get; set; }

    public string? strDescripcion { get; set; }
}
