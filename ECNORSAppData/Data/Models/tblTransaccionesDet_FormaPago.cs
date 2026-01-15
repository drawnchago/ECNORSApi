using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesDet_FormaPago
{
    public long intID { get; set; }

    public long? intTransaccion { get; set; }

    public int? intFormaPago { get; set; }

    public DateTime? datFechaHora { get; set; }

    public double? dblImporte { get; set; }

    public string? strDescripcion { get; set; }
}
