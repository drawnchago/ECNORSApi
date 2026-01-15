using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDocumento
{
    public long intLiquidacion { get; set; }

    public int intIsla { get; set; }

    public int intDocumento { get; set; }

    public int? intTipoDocumento { get; set; }

    public int? intBanco { get; set; }

    public string? strFolioDocumento { get; set; }

    public string? strNoCuenta { get; set; }

    public double? dblMonto { get; set; }
}
