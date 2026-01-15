using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblExistenciasCV
{
    public long intID { get; set; }

    public int? intTanque { get; set; }

    public int? intProducto { get; set; }

    public double? dblVolumenTotal { get; set; }

    public double? dblVolumenTC { get; set; }

    public double? dblVolumenUtil { get; set; }

    public double? dblVolumenFondaje { get; set; }

    public double? dblVolumenAgua { get; set; }

    public double? dblVolumenVacio { get; set; }

    public double? dblVolumenExtraccion { get; set; }

    public double? dblVolumenRecepcion { get; set; }

    public double? dblAlturaVolumen { get; set; }

    public double? dblAlturaAgua { get; set; }

    public double? dblTemperatura { get; set; }

    public string? strEstatus { get; set; }

    public DateTime? datFechaHora { get; set; }

    public DateTime? datFechaHoraAnterior { get; set; }
}
