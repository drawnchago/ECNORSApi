using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProductosHist
{
    public int? intProducto { get; set; }

    public double? dblPrecioU { get; set; }

    public int? intMes { get; set; }

    public int? intAño { get; set; }

    public DateTime? datFechaAlta { get; set; }
}
