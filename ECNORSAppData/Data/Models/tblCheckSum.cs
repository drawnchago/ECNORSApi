using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCheckSum
{
    public string? strTabla { get; set; }

    public string? strNombreLlave { get; set; }

    public string? strLlave { get; set; }

    public double? dblChkSum { get; set; }
}
