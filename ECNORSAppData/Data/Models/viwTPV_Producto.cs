using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwTPV_Producto
{
    public int intTPV { get; set; }

    public int? intIsla { get; set; }

    public int? intDispensario { get; set; }

    public int? intProducto { get; set; }

    public int? intManguera { get; set; }

    public string? strDescripcion { get; set; }
}
