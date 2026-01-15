using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCantidadTipoDespacho
{
    public int intIDCantidadTipoDespacho { get; set; }

    public int intCantidad { get; set; }

    public int intOpcion { get; set; }

    public int intIDTipoDespacho { get; set; }

    public bool bitEstatus { get; set; }
}
