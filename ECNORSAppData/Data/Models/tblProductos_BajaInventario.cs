using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProductos_BajaInventario
{
    public int? intProducto { get; set; }

    public DateTime? datFechaBaja { get; set; }

    public string? strUsuarioBaja { get; set; }
}
