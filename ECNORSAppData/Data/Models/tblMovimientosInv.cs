using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMovimientosInv
{
    public int intMovimiento { get; set; }

    public int? intTipoMovimiento { get; set; }

    public string? strDescripcion { get; set; }

    public bool bitActivo { get; set; }

    public virtual tblTiposMovimientoInv? intTipoMovimientoNavigation { get; set; }

    public virtual ICollection<tblMovimientosInvDet> tblMovimientosInvDets { get; set; } = new List<tblMovimientosInvDet>();
}
