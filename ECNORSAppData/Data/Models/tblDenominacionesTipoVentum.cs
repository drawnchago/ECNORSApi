using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDenominacionesTipoVentum
{
    public int intTipoVenta { get; set; }

    public decimal intDenominacion { get; set; }

    public string strDescripcion { get; set; } = null!;
}
