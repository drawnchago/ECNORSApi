using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tbl_CP_PreciosProgramado
{
    public int intId { get; set; }

    public string strEstacion { get; set; } = null!;

    public double dblPrecio { get; set; }

    public int intProducto { get; set; }

    public DateTime datFechaProgramada { get; set; }

    public DateTime? datFechaEnvioAEstacion { get; set; }

    public DateTime? datFechaEnvioANexgen { get; set; }

    public DateTime? datFechaVerificacionPrecio { get; set; }

    public DateTime? datFechaVigencia { get; set; }

    public string strStatus { get; set; } = null!;

    public DateTime datFechaAlta { get; set; }

    public string strUsuarioAlta { get; set; } = null!;

    public string strMaquinaAlta { get; set; } = null!;

    public bool bitActual { get; set; }
}
