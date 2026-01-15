using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMeta
{
    public int intId { get; set; }

    public int intMes { get; set; }

    public int intAño { get; set; }

    public double dblMeta { get; set; }

    public bool btActivo { get; set; }

    public bool btUnits { get; set; }
}
