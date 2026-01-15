using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblSesione
{
    public string strIdSession { get; set; } = null!;

    public int? intUsuario { get; set; }

    public int? intDispositivo { get; set; }

    public int? intProceso { get; set; }

    public int? intPaso { get; set; }

    public DateTime? datFechaInicio { get; set; }

    public int? intTiempo { get; set; }

    public string? strMensaje { get; set; }

    public int? intEstatus { get; set; }

    public DateTime? datFechaUltimaModificacion { get; set; }
}
