using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPromocione
{
    public long intID { get; set; }

    public long intPromocion { get; set; }

    public string strPromocion { get; set; } = null!;

    public int bitActiva { get; set; }

    public string? strArchivo { get; set; }

    public string? strOperacion { get; set; }
}
