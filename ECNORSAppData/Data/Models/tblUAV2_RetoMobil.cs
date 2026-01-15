using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_RetoMobil
{
    public long intTransaccion { get; set; }

    public int intTipo { get; set; }

    public DateTime datFechaHora { get; set; }
}
