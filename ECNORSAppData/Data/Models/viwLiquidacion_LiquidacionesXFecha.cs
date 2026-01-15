using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_LiquidacionesXFecha
{
    public string? strFecha { get; set; }

    public string? strFechaContable { get; set; }

    public long intFolioCorte { get; set; }

    public int intTurno { get; set; }

    public int intIsla { get; set; }

    public long intFolioLiquidacion { get; set; }

    public double dblImporteProductos { get; set; }

    public double dblImportePagos { get; set; }

    public double dblSobrante { get; set; }

    public double dblFaltante { get; set; }

    public int intUsuario { get; set; }

    public string strDespachador { get; set; } = null!;

    public string strDespachadores { get; set; } = null!;

    public int? ntUsuarioLiquidador { get; set; }

    public string? strLiquidador { get; set; }
}
