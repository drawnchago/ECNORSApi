using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class AUX_tblLikuitiDetPago
{
    public int intFormaPago { get; set; }

    public string? strDescripcion { get; set; }

    public double? dblTipoCambioMXP { get; set; }

    public double? dblImporte { get; set; }

    public double? dblImporteTotal { get; set; }

    public bool bitBloquear { get; set; }
}
