using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposArchivo
{
    public int intID { get; set; }

    public string strTipo { get; set; } = null!;

    public string? strDescripcion { get; set; }
}
