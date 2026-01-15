using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAcceso
{
    public int intAcceso { get; set; }

    public string strPrograma { get; set; } = null!;

    public string? strDescripcion { get; set; }
}
