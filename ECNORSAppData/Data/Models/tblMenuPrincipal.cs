using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMenuPrincipal
{
    public int intMenu { get; set; }

    public string strDescripcion { get; set; } = null!;

    public string strIDImagen { get; set; } = null!;

    public int intIDProceso { get; set; }

    public int intIDMenuPadre { get; set; }

    public bool? bitActivo { get; set; }
}
