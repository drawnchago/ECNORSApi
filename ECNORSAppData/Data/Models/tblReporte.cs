using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblReporte
{
    public int intReporte { get; set; }

    public int intTipoReporte { get; set; }

    public int intOrden { get; set; }

    public string? strNombre { get; set; }

    public string? strNombreFisico { get; set; }

    public string? strComandos { get; set; }

    public bool bitActivo { get; set; }
}
