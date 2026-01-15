using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblClientesComercializadorasAfiliada
{
    public long intID { get; set; }

    public long intClienteUG { get; set; }

    public string strNombreCliente { get; set; } = null!;
}
