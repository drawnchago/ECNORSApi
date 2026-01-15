using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraTL
{
    public long intID { get; set; }

    public DateTime? datFechaHora { get; set; }

    public string strComando { get; set; } = null!;

    public string strResultadoHex { get; set; } = null!;
}
