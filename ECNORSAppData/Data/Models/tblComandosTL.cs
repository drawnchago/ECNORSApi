using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblComandosTL
{
    public int intComando { get; set; }

    public string strComando { get; set; } = null!;

    public string strDescripcion { get; set; } = null!;
}
