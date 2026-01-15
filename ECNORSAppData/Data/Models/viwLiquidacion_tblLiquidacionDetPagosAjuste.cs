using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_tblLiquidacionDetPagosAjuste
{
    public long intFolioLiquidacion { get; set; }

    public long intSecuencia { get; set; }

    public int intFormaPago { get; set; }

    public string? strFormaPago { get; set; }

    public int? intTipoVenta { get; set; }

    public string? strTipoVenta { get; set; }

    public int? intMoneda { get; set; }

    public string? strMoneda { get; set; }

    public string? strAbreviatura { get; set; }

    public double? dblTipoCambioMXP { get; set; }

    public double? dblImporte { get; set; }

    public double? dblImporteTotal { get; set; }

    public DateTime? datFechaCaptura { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public string? strCapturo { get; set; }
}
