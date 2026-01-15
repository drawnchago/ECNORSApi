using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTotalizadorxDi
{
    public int intID { get; set; }

    public int intFolioCorteDis { get; set; }

    public int intDispensario { get; set; }

    public int intProducto { get; set; }

    public decimal? dblTotalizadorIni { get; set; }

    public decimal? dblTotalizadorFin { get; set; }

    public DateTime datFechaAlta { get; set; }
}
