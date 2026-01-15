using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposProducto
{
    public int intTipoProducto { get; set; }

    public string? strDescripcion { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public bool bitAlmacenable { get; set; }

    public bool bitAgrupado { get; set; }

    public virtual ICollection<tblProducto> tblProductos { get; set; } = new List<tblProducto>();
}
