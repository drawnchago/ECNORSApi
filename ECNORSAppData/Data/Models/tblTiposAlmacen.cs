using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposAlmacen
{
    public int intTipoAlmacen { get; set; }

    public string? strDescripcion { get; set; }

    public virtual ICollection<tblAlmacene> tblAlmacenes { get; set; } = new List<tblAlmacene>();
}
