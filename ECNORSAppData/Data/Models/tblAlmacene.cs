using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAlmacene
{
    public int intAlmacen { get; set; }

    public int? intTipoAlmacen { get; set; }

    public string? strDescripcion { get; set; }

    public virtual tblTiposAlmacen? intTipoAlmacenNavigation { get; set; }

    public virtual ICollection<tblExistencia> tblExistencia { get; set; } = new List<tblExistencia>();

    public virtual ICollection<tblMovimientosInvDet> tblMovimientosInvDets { get; set; } = new List<tblMovimientosInvDet>();
}
