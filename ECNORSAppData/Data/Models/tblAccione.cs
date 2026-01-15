using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblAccione
{
    public int intID { get; set; }

    public string? strAccion { get; set; }

    public string? strPrograma { get; set; }

    public string? strUsuario { get; set; }

    public string? strMaquina { get; set; }

    public DateTime? datFechaHora { get; set; }
}
