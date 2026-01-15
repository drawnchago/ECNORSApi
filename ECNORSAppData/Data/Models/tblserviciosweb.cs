using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblserviciosweb
{
    public long intID { get; set; }

    public int? intServicio { get; set; }

    public string? strNombreServicio { get; set; }

    public string? strURLServicio { get; set; }

    public string? strLlaveServicio { get; set; }

    public bool? bitLlaveServicio { get; set; }

    public bool? bitAppExterna { get; set; }

    public string? strParametros { get; set; }
}
