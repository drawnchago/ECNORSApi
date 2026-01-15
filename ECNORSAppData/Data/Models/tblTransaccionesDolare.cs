using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesDolare
{
    public long? intTransaccion { get; set; }

    public double? dblTipoCambio { get; set; }

    public double? dblImporteDolares { get; set; }

    public DateTime? datFechaContable { get; set; }

    public int? intTipoPersona { get; set; }
}
