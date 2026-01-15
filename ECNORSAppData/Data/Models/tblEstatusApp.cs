using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblEstatusApp
{
    public int intID { get; set; }

    public DateTime datFecha { get; set; }

    public string strEstatusMonitor { get; set; } = null!;

    public string strEstatusConsola { get; set; } = null!;

    public string strEstatusTransacciones { get; set; } = null!;

    public bool bitManualMonitor { get; set; }

    public bool bitAlerta { get; set; }

    public bool bitError { get; set; }

    public bool bitReportado { get; set; }
}
