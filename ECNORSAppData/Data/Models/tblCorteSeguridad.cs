using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCorteSeguridad
{
    public int intID { get; set; }

    public int intFolioCorte { get; set; }

    public int intFolioSeguridad { get; set; }

    public int intUsuario { get; set; }

    public DateTime datFecha { get; set; }

    public decimal dblImporte { get; set; }

    public bool bitCerrado { get; set; }
}
