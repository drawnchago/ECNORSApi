using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTipoDespacho
{
    public int intIDTipoDespacho { get; set; }

    public string strDescripcion { get; set; } = null!;

    public bool bitEstatus { get; set; }

    public DateTime datFechaAlta { get; set; }
}
