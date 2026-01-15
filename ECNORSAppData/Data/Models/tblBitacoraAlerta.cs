using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraAlerta
{
    public int intID { get; set; }

    public int intTanque { get; set; }

    public int intTipoAlerta { get; set; }

    public string strDescripcion { get; set; } = null!;

    public DateTime datFechaLectura { get; set; }

    public DateTime datFechaHora { get; set; }

    public decimal dblVolumen { get; set; }

    public string strProducto { get; set; } = null!;
}
