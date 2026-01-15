using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_ErrorLog
{
    public Guid LogID { get; set; }

    public DateTime LogDate { get; set; }

    public int TerminalID { get; set; }

    public int UsuarioID { get; set; }

    public string Estacion { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public string StackTrace { get; set; } = null!;

    public string TerminalSerie { get; set; } = null!;

    public string TerminalVersion { get; set; } = null!;

    public string? Datos { get; set; }
}
