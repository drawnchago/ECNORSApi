using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPreciosProgramado
{
    public int intProducto { get; set; }

    public double? dblPrecio { get; set; }

    public DateTime datFechaProgramada { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public bool? bitAfectado { get; set; }

    public string? strUsuarioAlta { get; set; }

    public string? strMaquinaAlta { get; set; }
}
