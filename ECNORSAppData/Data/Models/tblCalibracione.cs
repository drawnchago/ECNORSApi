using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCalibracione
{
    public int? intTanque { get; set; }

    public int? intDispensario { get; set; }

    public int? intManguera { get; set; }

    public DateTime? datFechaCalibracion { get; set; }

    public string? strMotivo { get; set; }

    public string? strRealizadaPor { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime? datFechaAlta { get; set; }
}
