using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposPago
{
    public int intID { get; set; }

    public int intTipoVenta { get; set; }

    public string? strDescripcion { get; set; }

    public bool? bitEstatus { get; set; }

    public bool? bitFidelidad { get; set; }
}
