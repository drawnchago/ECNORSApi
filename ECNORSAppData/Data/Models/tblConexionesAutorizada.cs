using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblConexionesAutorizada
{
    public int intID { get; set; }

    public string strNombre { get; set; } = null!;

    public string strDescripcion { get; set; } = null!;

    public string strIP { get; set; } = null!;

    public bool bitAutorizada { get; set; }
}
