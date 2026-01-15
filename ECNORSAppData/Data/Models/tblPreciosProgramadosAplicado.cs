using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPreciosProgramadosAplicado
{
    public int intId { get; set; }

    public int intProducto { get; set; }

    public double dblPrecio { get; set; }

    public DateTime datFechaProgramada { get; set; }

    public DateTime datFechaEnvíoANexGen { get; set; }

    public DateTime? datFechaVericiacionAplicacion { get; set; }

    public bool bitAfectado { get; set; }

    public string? strEstacion { get; set; }
}
