using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblColectasInicio
{
    public int? intFolioColecta { get; set; }

    public int? intFolioCorte { get; set; }

    public int? intUsuario { get; set; }

    public DateTime? datFechaHora { get; set; }
}
