using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRequisitosApp
{
    public int intID { get; set; }

    public int intRequisito { get; set; }

    public int intAPP { get; set; }

    public string strNombre { get; set; } = null!;

    public string strRutaArchivo { get; set; } = null!;

    public string strMD5 { get; set; } = null!;
}
