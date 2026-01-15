using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTerminale
{
    public int intTerminal { get; set; }

    public string? strTerminal { get; set; }

    public string? strPermisoAD { get; set; }

    public string? strUsoPreferente { get; set; }
}
