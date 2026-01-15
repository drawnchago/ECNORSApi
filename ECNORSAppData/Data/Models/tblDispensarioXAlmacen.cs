using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDispensarioXAlmacen
{
    public int intDispensario { get; set; }

    public int? intAlmacen { get; set; }

    public string strDescripcion { get; set; } = null!;
}
