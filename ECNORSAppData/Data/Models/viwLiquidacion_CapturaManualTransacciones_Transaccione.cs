using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_CapturaManualTransacciones_Transaccione
{
    public long intTransaccion { get; set; }

    public long intSecuencia { get; set; }

    public DateTime datFechahora { get; set; }

    public int intUsuario { get; set; }

    public string? strNombreCompleto { get; set; }

    public int intDispensario { get; set; }

    public int intProducto { get; set; }

    public string? strProducto { get; set; }

    public double dblVolumen { get; set; }

    public double dblImporte { get; set; }

    public int intModificable { get; set; }
}
