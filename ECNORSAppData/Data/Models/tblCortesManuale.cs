using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCortesManuale
{
    public long intFolioCorte { get; set; }

    public int intTurno { get; set; }

    public int intIsla { get; set; }

    public int intUsuario { get; set; }

    public int intProducto { get; set; }

    public double? dblLitros { get; set; }

    public double? dblImporte { get; set; }
}
