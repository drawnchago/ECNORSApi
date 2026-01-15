using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPermiso
{
    public int? intModulo { get; set; }

    public Guid? strGuid { get; set; }

    public string? strNombre { get; set; }

    public string? strDescripcion { get; set; }
}
