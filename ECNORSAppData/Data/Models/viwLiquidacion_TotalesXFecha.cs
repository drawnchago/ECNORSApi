using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalesXFecha
{
    public string? strFecha { get; set; }

    public double? dblImporteProductos { get; set; }

    public double? dblImportePagos { get; set; }

    public double? dblSobrante { get; set; }

    public double? dblFaltante { get; set; }
}
