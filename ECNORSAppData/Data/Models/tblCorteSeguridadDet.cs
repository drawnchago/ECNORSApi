using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCorteSeguridadDet
{
    public int intID { get; set; }

    public int intFolioSeguridad { get; set; }

    public int intFormaPago { get; set; }

    public decimal dblImporte { get; set; }
}
