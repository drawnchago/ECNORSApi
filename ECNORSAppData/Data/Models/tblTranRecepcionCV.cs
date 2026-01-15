using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTranRecepcionCV
{
    public int intID { get; set; }

    public int intFolioRecepcion { get; set; }

    public int intTransaccion { get; set; }

    public decimal? dblTemperatura { get; set; }

    public decimal? dblVolumenB { get; set; }

    public decimal? dblVolumenN { get; set; }

    public DateTime datFechaAlta { get; set; }
}
