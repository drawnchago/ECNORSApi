using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRegistroEjecucionActualizacion
{
    public int intId { get; set; }

    public string strVersion { get; set; } = null!;

    public DateTime datFechaEjecucion { get; set; }
}
