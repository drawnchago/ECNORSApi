using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_tblLiquidacionDetPago
{
    public long intFolioLiquidacion { get; set; }

    public int intFormaPago { get; set; }

    public double? dblTipoCambioMXP { get; set; }

    public double? dblImporte { get; set; }

    public double? dblImporteTotal { get; set; }
}
