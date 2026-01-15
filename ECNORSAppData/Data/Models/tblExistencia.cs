using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblExistencia
{
    public int intAlmacen { get; set; }

    public int intProducto { get; set; }

    public double? dblCantidad { get; set; }

    public virtual tblAlmacene intAlmacenNavigation { get; set; } = null!;

    public virtual tblProducto intProductoNavigation { get; set; } = null!;
}
