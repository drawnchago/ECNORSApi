using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDictamenesENC
{
    public int intId { get; set; }

    public string? strRFC { get; set; }

    public string? strNombre { get; set; }

    public string? strFolio { get; set; }

    public DateTime? datFechaEmision { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime? datFechaAlta { get; set; }
}
