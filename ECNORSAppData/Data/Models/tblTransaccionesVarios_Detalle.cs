using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesVarios_Detalle
{
    public long intID { get; set; }

    public long? intFolioCorte { get; set; }

    public long? intTransaccion { get; set; }

    public DateTime? datFechaHora { get; set; }

    public int? intTPV { get; set; }

    public int? intTipoVenta { get; set; }

    public int? intFormaPago { get; set; }

    public int? intDispensario { get; set; }

    public int? intTipoProducto { get; set; }

    public int? intProducto { get; set; }

    public double? dblPrecioUnitario { get; set; }

    public int? intCantidad { get; set; }

    public double? dblImporte { get; set; }

    public int? intUsuario { get; set; }
}
