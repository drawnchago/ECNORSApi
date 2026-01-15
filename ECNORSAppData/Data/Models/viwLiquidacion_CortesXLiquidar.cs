using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_CortesXLiquidar
{
    public long Actual { get; set; }

    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public DateTime? datFechaContable { get; set; }

    public int? intTurno { get; set; }

    public DateTime datFechaInicial { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public bool bitLiquidado { get; set; }
}
