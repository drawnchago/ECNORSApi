using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class CVVentas_Paso
{
    public string strFecha { get; set; } = null!;

    public int intTransaccion { get; set; }

    public string strProducto { get; set; } = null!;

    public decimal decVolumen { get; set; }

    public decimal decPrecio { get; set; }

    public decimal decImporte { get; set; }

    public string strLineaCV { get; set; } = null!;
}
