using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblFoliosReleacionRecepcionesDocumento
{
    public long intID { get; set; }

    public long? intFolioRecepcion { get; set; }

    public long? intFolioLote { get; set; }

    public long? intDiferenciaHoraCaptura { get; set; }
}
