using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPaso
{
    public int intIDPaso { get; set; }

    public string strNombre { get; set; } = null!;

    public int intIDTipoControl { get; set; }

    public string? strQueryObtieneValores { get; set; }

    public bool bitExterno { get; set; }

    public bool bitInterfiereHumano { get; set; }

    public string? strDLLControl { get; set; }

    public string? strClassControl { get; set; }
}
