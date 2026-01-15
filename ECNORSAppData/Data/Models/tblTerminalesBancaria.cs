using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTerminalesBancaria
{
    public long intID { get; set; }

    public int intTPV { get; set; }

    public int intPuerto { get; set; }

    public string strBaudRate { get; set; } = null!;

    public string strParity { get; set; } = null!;

    public int intStopBits { get; set; }

    public int intDataBits { get; set; }

    public string? strNoSerial { get; set; }
}
