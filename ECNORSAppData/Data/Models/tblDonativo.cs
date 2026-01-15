using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDonativo
{
    public int intDonativo { get; set; }

    public int? intProducto { get; set; }

    public string? strDescripcion { get; set; }

    public string? strRutaReporte { get; set; }
}
