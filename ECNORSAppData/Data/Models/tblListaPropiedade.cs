using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblListaPropiedade
{
    public string? strIDSesion { get; set; }

    public string? strPropiedad { get; set; }

    public int? intValor { get; set; }

    public string? strValor { get; set; }

    public byte[]? byteValor { get; set; }

    public decimal? decValor { get; set; }
}
