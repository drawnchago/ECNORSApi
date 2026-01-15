using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCargaInicialInventario
{
    public int intAlmacen { get; set; }

    public int intProducto { get; set; }

    public double? dblCantidad { get; set; }

    public double? dblCosto { get; set; }

    public double? dblPrecio { get; set; }
}
