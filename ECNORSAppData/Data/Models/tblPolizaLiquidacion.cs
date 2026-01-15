using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPolizaLiquidacion
{
    public DateTime datFecha { get; set; }

    public int intProducto { get; set; }

    public double dblPrecioU { get; set; }

    public double dblCantidad { get; set; }

    public double dblTotal { get; set; }

    public double? dblPreciosinIEPS { get; set; }

    public double dblTotalIva { get; set; }

    public double? dblTotalIEPS { get; set; }

    public double dblCantidadCalculo { get; set; }

    public double dblCantidadJarreo { get; set; }

    public double dblTotalJarreo { get; set; }

    public double dblTotalIVAJarreo { get; set; }

    public double? dblTotalIEPSJarreo { get; set; }
}
