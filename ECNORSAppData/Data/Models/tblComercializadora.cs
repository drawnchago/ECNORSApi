using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblComercializadora
{
    public int intID { get; set; }

    public int intComercializadora { get; set; }

    public string strDescripcion { get; set; } = null!;

    public bool bitFidelidad { get; set; }

    public bool bitActivo { get; set; }
}
