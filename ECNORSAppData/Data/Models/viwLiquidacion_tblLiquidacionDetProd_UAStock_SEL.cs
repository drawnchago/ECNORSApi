using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_tblLiquidacionDetProd_UAStock_SEL
{
    public long intFolioLiquidacion { get; set; }

    public int intProducto { get; set; }

    public string? strProducto { get; set; }

    public double? dblExistenciaInicial { get; set; }

    public double? dblEntradas { get; set; }

    public double? dblExistenciaFinal { get; set; }

    public double? dblSalidas { get; set; }

    public double? dblTotalVenta { get; set; }

    public double dblPrecioUnitario { get; set; }
}
