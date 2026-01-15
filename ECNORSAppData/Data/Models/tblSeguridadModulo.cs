using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblSeguridadModulo
{
    public int intModulo { get; set; }

    public string strDescripcion { get; set; } = null!;

    public virtual ICollection<tblSeguridadNivele> tblSeguridadNiveles { get; set; } = new List<tblSeguridadNivele>();
}
