using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPagoGOBenefit
{
    public int ID { get; set; }

    public int? intTransaccion { get; set; }

    public string? strBandaM { get; set; }

    public decimal? decMonto { get; set; }

    public string? strCodigoTrx { get; set; }

    public string? strCodigoInterno { get; set; }

    public string? strMensaje { get; set; }

    public DateTime? datFechaPago { get; set; }
}
