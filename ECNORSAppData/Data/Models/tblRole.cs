using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRole
{
    public int? intRol { get; set; }

    public string? strNombre { get; set; }

    public string? strDescripcion { get; set; }

    public bool? bitActivo { get; set; }
}
