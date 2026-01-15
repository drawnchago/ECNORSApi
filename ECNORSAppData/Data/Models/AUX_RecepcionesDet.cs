using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class AUX_RecepcionesDet
{
    public int? intPartida { get; set; }

    public int? intProducto { get; set; }

    public string? strDescripcion { get; set; }

    public string? strTipoProducto { get; set; }

    public double? dblCantidad { get; set; }

    public double? dblCostoUnitario { get; set; }

    public double? dblCostoTotal { get; set; }
}
