using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPasosManager_mar01_2025
{
    public int? intIDPaso { get; set; }

    public string? strNombre { get; set; }

    public string? strQueryValores { get; set; }

    public int? intTipoVentana { get; set; }

    public bool? bitCondicional { get; set; }

    public string? strPropiedadesCondicion { get; set; }

    public string? strValoresCondicion { get; set; }
}
