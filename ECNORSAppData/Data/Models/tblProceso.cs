using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProceso
{
    public int intIDProceso { get; set; }

    public string strDescripcion { get; set; } = null!;

    public int intTiempo { get; set; }
}
