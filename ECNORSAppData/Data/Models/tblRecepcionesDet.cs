using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRecepcionesDet
{
    public long intRecepcion { get; set; }

    public int intPartida { get; set; }

    public int? intProducto { get; set; }

    public double? dblCantidad { get; set; }

    public double? dblCostoUnitario { get; set; }

    public double? dblCostoTotal { get; set; }

    public virtual tblProducto? intProductoNavigation { get; set; }

    public virtual tblRecepcionesEnc intRecepcionNavigation { get; set; } = null!;
}
