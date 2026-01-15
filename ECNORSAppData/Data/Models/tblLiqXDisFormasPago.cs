using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLiqXDisFormasPago
{
    public int? intFolioLiquidacionDis { get; set; }

    public int intFormaPago { get; set; }

    public string strDescripcion { get; set; } = null!;

    public decimal? dblMonto { get; set; }
}
