using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblWSSEP
{
    public int intID { get; set; }

    public int? intProducto { get; set; }

    public string? strProducto { get; set; }

    public int? intTanque { get; set; }

    public int? intTPV { get; set; }

    public int? intDispensario { get; set; }

    public int? intManguera { get; set; }
}
