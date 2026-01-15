using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblConfiguracionWebService
{
    public string? strURL_LAN { get; set; }

    public string? strURL_WAN { get; set; }

    public string? strPassword { get; set; }

    public int? intTLS { get; set; }

    public string? strDescripcion { get; set; }
}
