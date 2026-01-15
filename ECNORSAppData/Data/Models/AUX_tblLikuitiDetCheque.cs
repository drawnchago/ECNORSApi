using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class AUX_tblLikuitiDetCheque
{
    public int intDocumento { get; set; }

    public int intTipoDocumento { get; set; }

    public string strDocumento { get; set; } = null!;

    public int intBanco { get; set; }

    public string strBanco { get; set; } = null!;

    public string? strFolioDocumento { get; set; }

    public string? strCuenta { get; set; }

    public double dblMonto { get; set; }
}
