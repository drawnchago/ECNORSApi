using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblImpresione
{
    public int intTransaccion { get; set; }

    public int intTipo { get; set; }

    public DateTime datFechaHora { get; set; }
}
