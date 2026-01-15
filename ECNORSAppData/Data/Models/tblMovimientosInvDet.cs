using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMovimientosInvDet
{
    public long intID { get; set; }

    public long intSecuencia { get; set; }

    public int? intMovimiento { get; set; }

    public int? intAlmacen { get; set; }

    public int? intProducto { get; set; }

    public double? dblCantidad { get; set; }

    public string? strReferencia { get; set; }

    public string? strDescripcion { get; set; }

    public DateTime datFecha { get; set; }

    public string? strUsuario { get; set; }

    public string? strPC { get; set; }

    public virtual tblAlmacene? intAlmacenNavigation { get; set; }

    public virtual tblMovimientosInv? intMovimientoNavigation { get; set; }

    public virtual tblProducto? intProductoNavigation { get; set; }
}
