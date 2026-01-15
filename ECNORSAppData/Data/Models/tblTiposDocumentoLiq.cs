using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposDocumentoLiq
{
    public int intTipoDocumento { get; set; }

    public string? strDescripcion { get; set; }

    public bool bitActivo { get; set; }
}
