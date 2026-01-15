using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAlarmaTanque
{
    public int intID { get; set; }

    public int? intTanque { get; set; }

    public int? intProducto { get; set; }

    public DateTime? datFechaHora { get; set; }

    public string? strEstatus { get; set; }

    public string? strGenerado { get; set; }
}
