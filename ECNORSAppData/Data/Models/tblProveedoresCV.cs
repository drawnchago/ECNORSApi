using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProveedoresCV
{
    public int intProveedor { get; set; }

    public string strTipoProveedor { get; set; } = null!;

    public string? strPermisoImportacion { get; set; }

    public string? strRFCProveedor { get; set; }

    public string strNombreProveedor { get; set; } = null!;

    public string? strPermisoProveedor { get; set; }

    public string? strDescripcion { get; set; }

    public bool? bitActivo { get; set; }
}
