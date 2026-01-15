using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblWSSEp_Transaccione
{
    public int intID { get; set; }

    public long? intFolioTransaccion { get; set; }

    public int? intTerminal { get; set; }

    public string? strXml { get; set; }

    public string? strClaveVehiculo { get; set; }

    public string? strPermisoTrans { get; set; }

    public decimal? dblDencidad { get; set; }

    public string? strPermisoAlma { get; set; }

    public DateTime? datFecha { get; set; }

    public DateTime? datFechaAlta { get; set; }
}
