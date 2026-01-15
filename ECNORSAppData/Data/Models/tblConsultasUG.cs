using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblConsultasUG
{
    public int? intSecuencia { get; set; }

    public string? strIdConsulta { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public bool? bitProcesada { get; set; }

    public int? intTipo { get; set; }
}
