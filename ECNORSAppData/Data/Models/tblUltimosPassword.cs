using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUltimosPassword
{
    public int id { get; set; }

    public string? strUser { get; set; }

    public byte[]? strPassword { get; set; }

    public DateTime? datFechaHora { get; set; }
}
