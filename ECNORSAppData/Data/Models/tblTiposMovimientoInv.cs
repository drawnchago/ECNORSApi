using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposMovimientoInv
{
    public int intTipoMovimiento { get; set; }

    public string? strDescripcion { get; set; }

    public string? strDescripcionCorta { get; set; }

    public int? intSigno { get; set; }

    public bool? bitActivo { get; set; }

    public virtual ICollection<tblMovimientosInv> tblMovimientosInvs { get; set; } = new List<tblMovimientosInv>();
}
