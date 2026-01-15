using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viw_CICAlarma
{
    public string strAlarma { get; set; } = null!;

    public string strTipo { get; set; } = null!;

    public string? strNomCategoria { get; set; }

    public string? strNomTipo { get; set; }
}
