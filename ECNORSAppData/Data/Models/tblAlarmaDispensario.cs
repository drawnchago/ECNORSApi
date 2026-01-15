using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAlarmaDispensario
{
    public int? intDispensario { get; set; }

    public int? intManguera { get; set; }

    public int? intProducto { get; set; }

    public DateTime? datFechaHora { get; set; }

    public string? strEstatus { get; set; }

    public string? strGenerado { get; set; }
}
