using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCortesReporte
{
    public long? intFolioCorte { get; set; }

    public int? intIsla { get; set; }

    public int? intProducto { get; set; }

    public double? dblCorteL { get; set; }

    public double? dblCorteP { get; set; }

    public int? intEstatus { get; set; }

    public DateTime? datFechaCorte { get; set; }

    public double dblPrecioUnitario { get; set; }
}
