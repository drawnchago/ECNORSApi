using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLogConsultaUG
{
    public int? intSecuencia { get; set; }

    public int? intCodigoRespuesta { get; set; }

    public string? strMensajeRespuesta { get; set; }

    public string? strTipodeConsulta { get; set; }

    public DateTime? datFecha { get; set; }
}
