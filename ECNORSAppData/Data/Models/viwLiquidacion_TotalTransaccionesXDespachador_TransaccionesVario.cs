using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_TotalTransaccionesXDespachador_TransaccionesVario
{
    public long? intFolioCorte { get; set; }

    public int? intTurno { get; set; }

    public int? intIsla { get; set; }

    public int? intProducto { get; set; }

    public int? dblLitros { get; set; }

    public double? dblImporte { get; set; }

    public int? intUsuario { get; set; }

    public string? strNombre { get; set; }

    public string? strAPaterno { get; set; }

    public string? strAMaterno { get; set; }

    public string? strNombreCompleto { get; set; }

    public double? dblPrecioUnitario { get; set; }
}
