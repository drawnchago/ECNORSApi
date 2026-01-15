using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProveedoresCRE
{
    public int intID { get; set; }

    public string strPermisoCRE { get; set; } = null!;

    public string strNombre { get; set; } = null!;

    public int bitActivo { get; set; }
}
