using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraImpresion
{
    public long intBitacoraImpresion { get; set; }

    public long intIDTransaccion { get; set; }

    public int intUsuario { get; set; }

    public string strTipoImpresion { get; set; } = null!;

    public DateTime datFechaHora { get; set; }
}
