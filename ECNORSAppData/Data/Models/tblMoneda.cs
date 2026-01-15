using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMoneda
{
    public int intMoneda { get; set; }

    public string strDescripcion { get; set; } = null!;

    public string strNombreCorto { get; set; } = null!;

    public string strAbreviatura { get; set; } = null!;

    public double dblTipoCambioMXP { get; set; }

    public bool bitActivo { get; set; }
}
