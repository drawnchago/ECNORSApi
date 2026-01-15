using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMensajesApp
{
    public int intID { get; set; }

    public int intIDReporte { get; set; }

    public string strMensaje { get; set; } = null!;
}
