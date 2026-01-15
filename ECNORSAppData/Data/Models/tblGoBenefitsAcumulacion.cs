using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblGoBenefitsAcumulacion
{
    public int intTransaccion { get; set; }

    public int intTransaccionGoBenefits { get; set; }

    public DateTime datFecha { get; set; }

    public double decPuntos { get; set; }
}
