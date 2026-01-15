using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraTXCenter
{
    public DateTime Fecha { get; set; }

    public string Mensaje { get; set; } = null!;

    public string? Usuario { get; set; }

    public string? TPV { get; set; }

    public string? IdSesion { get; set; }

    public int? TiempoMs { get; set; }

    public int? TotalTiempoMs { get; set; }

    public bool? EsError { get; set; }
}
