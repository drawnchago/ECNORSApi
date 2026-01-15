using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_ConexionEndpoint
{
    public DateTime LogDate { get; set; }

    public int TerminalID { get; set; }

    public string IP { get; set; } = null!;

    public int DispensarioID { get; set; }

    public string Endpoint { get; set; } = null!;

    public string Evento { get; set; } = null!;

    public int ConexionesActivas { get; set; }
}
