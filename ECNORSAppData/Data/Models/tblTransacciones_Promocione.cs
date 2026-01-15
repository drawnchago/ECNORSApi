using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransacciones_Promocione
{
    public long intID { get; set; }

    public long intTransaccion { get; set; }

    public int? intPromocion { get; set; }

    public int intCantidad { get; set; }
}
