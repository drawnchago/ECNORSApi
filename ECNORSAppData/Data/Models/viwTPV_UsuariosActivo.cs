using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwTPV_UsuariosActivo
{
    public long intFolioCorte { get; set; }

    public int? intUsuario { get; set; }

    public string? strNombre { get; set; }

    public string? strAPaterno { get; set; }

    public string? strAMaterno { get; set; }

    public int? intGrupo { get; set; }

    public string? strIdentificador { get; set; }

    public int? intTurno { get; set; }

    public int? intIsla { get; set; }

    public int? intTPV { get; set; }

    public int? intTurnoAsignado { get; set; }

    public bool? bitIDActivo { get; set; }

    public bool? bitActivo { get; set; }
}
