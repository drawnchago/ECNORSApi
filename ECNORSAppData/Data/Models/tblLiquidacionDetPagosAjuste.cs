using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLiquidacionDetPagosAjuste
{
    public long intFolioLiquidacion { get; set; }

    public int intFormaPago { get; set; }

    public long intSecuencia { get; set; }

    public double? dblTipoCambioMXP { get; set; }

    public double? dblImporte { get; set; }

    public double? dblImporteTotal { get; set; }

    public DateTime? datFechaCaptura { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public string? strPCCaptura { get; set; }
}
