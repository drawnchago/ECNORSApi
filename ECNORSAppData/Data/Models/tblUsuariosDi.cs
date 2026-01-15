using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUsuariosDi
{
    public int intID { get; set; }

    public int intFolioCorteDis { get; set; }

    public int intUsuario { get; set; }

    public int intDispensario { get; set; }

    public bool bitActivo { get; set; }

    public string strUsuarioAlta { get; set; } = null!;

    public DateTime datFechaAlta { get; set; }
}
