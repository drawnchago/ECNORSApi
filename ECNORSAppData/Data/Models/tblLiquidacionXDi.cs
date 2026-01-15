using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLiquidacionXDi
{
    public int intId { get; set; }

    public int? intFolioLiquidacionDis { get; set; }

    public int? intFolioCorte { get; set; }

    public int? intDispensario { get; set; }

    public string? strDespachador { get; set; }

    public string? strUsuarioLiquidacion { get; set; }

    public DateTime datFechaAlta { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public bool bitLiquidado { get; set; }
}
