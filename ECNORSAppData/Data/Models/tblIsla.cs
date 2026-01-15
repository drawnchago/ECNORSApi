using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblIsla
{
    public int intIsla { get; set; }

    public int intAlmacen { get; set; }

    public string strDescripcion { get; set; } = null!;

    public string? strImpresora { get; set; }

    public virtual ICollection<tblDispensario> tblDispensarios { get; set; } = new List<tblDispensario>();

    public virtual ICollection<tblUsuarioIsla> tblUsuarioIslas { get; set; } = new List<tblUsuarioIsla>();
}
