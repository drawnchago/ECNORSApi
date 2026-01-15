using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblParametrosServiciosWEB
{
    public int intID { get; set; }

    public int intServicio { get; set; }

    public int intParametro { get; set; }

    public string? strNombreParametro { get; set; }

    public string? strValorParametro { get; set; }
}
