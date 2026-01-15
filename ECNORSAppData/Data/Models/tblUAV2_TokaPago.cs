using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_TokaPago
{
    public DateTime datFechaHora { get; set; }

    public int intSecuencia { get; set; }

    public long intTransaccion { get; set; }

    public string idRespuesta { get; set; } = null!;

    public string idAutorizacion { get; set; } = null!;

    public string strPrevalidacionJSON { get; set; } = null!;

    public string strAutorizacionJSON { get; set; } = null!;

    public bool bitReintento { get; set; }

    public string? strMotivoFallo { get; set; }

    public decimal? dblMonto { get; set; }
}
