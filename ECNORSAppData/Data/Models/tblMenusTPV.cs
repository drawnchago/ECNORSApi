using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMenusTPV
{
    public int intID { get; set; }

    public int intMenu { get; set; }

    public string strMenuPadre { get; set; } = null!;

    public string? strMenuSiguiente { get; set; }

    public string strMenu { get; set; } = null!;

    public bool bitEjecuta { get; set; }

    public string? strArchivo { get; set; }

    public string? strParametros { get; set; }

    public bool? bitDLL { get; set; }
}
