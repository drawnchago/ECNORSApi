using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesPinPad
{
    public int intID { get; set; }

    public int intTransaccion { get; set; }

    public decimal decMonto { get; set; }

    public decimal decPropina { get; set; }

    public DateTime datFechaAlta { get; set; }

    public int intNoControl { get; set; }

    public int intTipo { get; set; }
}
