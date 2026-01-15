using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblInventarioTanques_CV
{
    public int? intTanque { get; set; }

    public int? intProducto { get; set; }

    public DateTime? datFechaLectura { get; set; }

    public double? dblVolumenTC { get; set; }

    public double? dblVolumen { get; set; }

    public double? dblVolumenXLlenar { get; set; }

    public double? dblNivelCombustible { get; set; }

    public double? dblNivelAgua { get; set; }

    public double? dblTemperatura { get; set; }

    public double? dblVolumenAgua { get; set; }
}
