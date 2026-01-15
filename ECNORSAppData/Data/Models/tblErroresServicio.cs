using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblErroresServicio
{
    public long intID { get; set; }

    public long? intTransaccion { get; set; }

    public DateTime? datFechaHora { get; set; }

    public int? intUsuario { get; set; }

    public int? intTPV { get; set; }

    public int? intDispensario { get; set; }

    public string? strTipoError { get; set; }

    public int? intError { get; set; }

    public string? strMensaje { get; set; }

    public string? strTelefono { get; set; }

    public string? strCompania { get; set; }
}
