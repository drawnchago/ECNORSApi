using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblFormasPago
{
    public int intFormaPago { get; set; }

    public string strDescripcion { get; set; } = null!;

    public int intTipoVenta { get; set; }

    public int intMoneda { get; set; }

    public bool bitActivo { get; set; }

    public bool? bitBloquearCaptura { get; set; }

    public virtual ICollection<tblLiquidacionDetPago> tblLiquidacionDetPagos { get; set; } = new List<tblLiquidacionDetPago>();
}
