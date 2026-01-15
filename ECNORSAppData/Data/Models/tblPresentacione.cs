using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPresentacione
{
    public int intPresentacion { get; set; }

    public string? strDescripcion { get; set; }

    public virtual ICollection<tblProducto> tblProductos { get; set; } = new List<tblProducto>();
}
