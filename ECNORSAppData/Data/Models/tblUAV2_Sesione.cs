using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_Sesione
{
    public Guid SesionID { get; set; }

    public int UsuarioID { get; set; }

    public int TerminalID { get; set; }

    public DateTime Fecha { get; set; }

    public string? TerminalClave { get; set; }

    public string? TerminalSerie { get; set; }

    public string? TerminalVersion { get; set; }
}
