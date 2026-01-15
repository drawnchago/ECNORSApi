using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_WSHelperLog
{
    public Guid LogID { get; set; }

    public DateTime LogDate { get; set; }

    public int Action { get; set; }

    public bool ShowWait { get; set; }

    public int TimeoutSeconds { get; set; }

    public string RequestMethod { get; set; } = null!;

    public string URL { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string? Token { get; set; }

    public string? Data { get; set; }

    public string? Listener { get; set; }

    public int? ResponseCode { get; set; }

    public bool? Successful { get; set; }

    public string? Result { get; set; }

    public string? Error { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public long? Milliseconds { get; set; }

    public int? TerminalID { get; set; }

    public string? Estacion { get; set; }

    public int? UsuarioID { get; set; }

    public string? TerminalSerie { get; set; }

    public string? TerminalVersion { get; set; }
}
