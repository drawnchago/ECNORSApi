using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAplicacione
{
    public int intID { get; set; }

    public int intApp { get; set; }

    public string strNombre { get; set; } = null!;

    public string? strDescripcion { get; set; }

    public string strRutaArchivo { get; set; } = null!;

    public string strMD5 { get; set; } = null!;

    public bool bitRequiereConsola { get; set; }

    public bool bitActivo { get; set; }
}
