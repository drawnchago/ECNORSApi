using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTranMonedero
{
    public int intID { get; set; }

    public int intTransaccion { get; set; }

    public int intFolio { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime datFechaAlta { get; set; }
}
