using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTanques_CV
{
    public string strFolioPemex { get; set; } = null!;

    public int intTanque { get; set; }

    public int intProducto { get; set; }

    public DateTime datFechaLectura { get; set; }

    public double? dblVolumenTC { get; set; }

    public double? dblVolumenTotal { get; set; }

    public double? dblVolumenVacio { get; set; }

    public double? dblAlturaVolumen { get; set; }

    public double? dblAlturaAgua { get; set; }

    public double? dblTemperatura { get; set; }

    public double? dblVolumenAgua { get; set; }

    public DateTime? datfechahora { get; set; }
}
