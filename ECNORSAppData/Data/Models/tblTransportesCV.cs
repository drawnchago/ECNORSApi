using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransportesCV
{
    public int intTransporte { get; set; }

    public string strTipoTransporte { get; set; } = null!;

    public string? strPermisoTransporte { get; set; }

    public string? strDescripcion { get; set; }

    public bool? bitActivo { get; set; }
}
