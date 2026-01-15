using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTPVMenu
{
    public int intMenu { get; set; }

    public int intOrden { get; set; }

    public string strOpcion { get; set; } = null!;

    public string? strDescripcion { get; set; }

    public string? strValor { get; set; }

    public int? intMenuSiguiente { get; set; }
}
