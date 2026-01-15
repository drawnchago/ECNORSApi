using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class AUX_tblLikuitiDetProd
{
    public long intProducto { get; set; }

    public string? strProducto { get; set; }

    public string? strTipoProducto { get; set; }

    public double? dblPrecioU { get; set; }

    public double? dblExistenciaInicial { get; set; }

    public double? dblEntradas { get; set; }

    public double? dblExistenciaFinal { get; set; }

    public double? dblSalidas { get; set; }

    public double? dblTotalImporte { get; set; }

    public bool? bitBloquear { get; set; }

    public int? intColor { get; set; }
}
