using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblParametrosTPV
{
    public int intIDParametro { get; set; }

    public string strNombre { get; set; } = null!;

    public string strValorDefault { get; set; } = null!;

    public string strTipo { get; set; } = null!;

    public bool bitEstatus { get; set; }
}
