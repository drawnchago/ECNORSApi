using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblFoliosCorteDi
{
    public int intFolioCorteDis { get; set; }

    public int intDispensario { get; set; }

    public int intUsuario { get; set; }

    public DateTime datFechaIni { get; set; }

    public DateTime? datFechaFin { get; set; }

    public string strUsuarioAlta { get; set; } = null!;

    public DateTime datFechaAlta { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public bool bitCerrado { get; set; }

    public bool bitLiquidado { get; set; }
}
