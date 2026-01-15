using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposTransaccion
{
    public int intTipoTransaccion { get; set; }

    public string strTipoTransaccion { get; set; } = null!;

    public string? strDescripcion { get; set; }

    public bool bitActivo { get; set; }

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
