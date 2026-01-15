using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLectorBitacora
{
    public string? Lector { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Mensaje { get; set; }
}
