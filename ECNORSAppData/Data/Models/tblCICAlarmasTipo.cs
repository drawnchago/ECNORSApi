using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCICAlarmasTipo
{
    public string strAlarmaCat { get; set; } = null!;

    public string strAlarmaTipo { get; set; } = null!;

    public string? strDescripcion { get; set; }
}
