using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblManguera
{
    public int intID { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public int intProducto { get; set; }

    public int? bitActivo { get; set; }

    public int? bitIntegrado { get; set; }

    public string? strTipoSurtidor { get; set; }

    public int? NZGroup { get; set; }

    public int? NZChannel { get; set; }

    public string? NZToken { get; set; }

    public string? NZTokenAValidar { get; set; }

    public decimal? dblLimiteLitros { get; set; }

    public decimal? dblLimiteImporte { get; set; }

    public virtual tblDispensario intDispensarioNavigation { get; set; } = null!;

    public virtual tblProducto intProductoNavigation { get; set; } = null!;

    public virtual ICollection<tblTotalizadore> tblTotalizadores { get; set; } = new List<tblTotalizadore>();

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
