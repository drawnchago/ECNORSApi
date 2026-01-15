using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTotalizadoresManuale
{
    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public long intIsla { get; set; }

    public long intDispensario { get; set; }

    public long intManguera { get; set; }

    public long intProducto { get; set; }

    public double dblPrecio { get; set; }

    public double dblTotalLitrosInicial { get; set; }

    public double dblTotalLitrosFinal { get; set; }

    public DateTime datFechaInicio { get; set; }

    public DateTime datFechaFinal { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public string? strMaquinaAlta { get; set; }
}
