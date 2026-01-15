using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTanque
{
    public int intTanque { get; set; }

    public int intProducto { get; set; }

    public double? dblCapacidadTotal { get; set; }

    public double? dblCapacidadOperativa { get; set; }

    public double? dblCapacidadUtil { get; set; }

    public double? dblCapacidadFondaje { get; set; }

    public double? dblVolumenMinimo { get; set; }

    public double? dblVolumenTotal { get; set; }

    public double? dblVolumenUtil { get; set; }

    public double? dblVolumenAgua { get; set; }

    public double? dblVolumenVacio { get; set; }

    public double? dblVolumenRecepcion { get; set; }

    public double? dblVolumenTC { get; set; }

    public double? dblTemperatura { get; set; }

    public double? dblAlturaAgua { get; set; }

    public double? dblAlturaVolumen { get; set; }

    public string strEstatus { get; set; } = null!;

    public DateTime? datFechaHora { get; set; }

    public DateTime? datFechaLectura { get; set; }

    public bool? bitEliminado { get; set; }

    public virtual tblProducto intProductoNavigation { get; set; } = null!;
}
