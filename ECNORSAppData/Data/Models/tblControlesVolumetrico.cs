using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblControlesVolumetrico
{
    public string strFecha { get; set; } = null!;

    public bool bitGenerado { get; set; }

    public string? strMsgGenerado { get; set; }

    public bool bitEnviado { get; set; }

    public string? strMsgEnviado { get; set; }

    public bool bitProcesado { get; set; }

    public string? strMsgProcesado { get; set; }

    public bool bitError { get; set; }

    public string? strMsgError { get; set; }

    public int intIntentos { get; set; }

    public DateTime datFechaUltimoProceso { get; set; }
}
