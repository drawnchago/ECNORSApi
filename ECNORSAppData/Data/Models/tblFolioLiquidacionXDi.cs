using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblFolioLiquidacionXDi
{
    public int intFolioLiquidacionDis { get; set; }

    public int? intUsuario { get; set; }

    public string? strUsuarioLiquidacion { get; set; }

    public DateTime datFechaAlta { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public bool bitLiquidado { get; set; }
}
