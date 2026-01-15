using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCorteSeguridadDesgloce
{
    public int intID { get; set; }

    public int intFolioSeguridad { get; set; }

    public int intFormaPago { get; set; }

    public decimal intCantidad { get; set; }

    public decimal intDenominacion { get; set; }
}
