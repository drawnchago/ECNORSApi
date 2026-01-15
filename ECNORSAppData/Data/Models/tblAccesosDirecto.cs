using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAccesosDirecto
{
    public int intAcceso { get; set; }

    public int intTipoVenta { get; set; }

    public bool bitAcumulaPuntos { get; set; }

    public int intProducto { get; set; }

    public int intTipoDespacho { get; set; }

    public int intCantidad { get; set; }

    public string? strImagen { get; set; }

    public string? strDescripcion { get; set; }
}
