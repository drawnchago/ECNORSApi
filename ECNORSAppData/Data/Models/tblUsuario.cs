using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUsuario
{
    public int intUsuario { get; set; }

    public string strNombre { get; set; } = null!;

    public string strAPaterno { get; set; } = null!;

    public string strAMaterno { get; set; } = null!;

    public int intEmpleadoNomina { get; set; }

    public int intGrupo { get; set; }

    public string? strIdentificador { get; set; }

    public string? strUser { get; set; }

    public bool bitActivo { get; set; }

    public int? intTurno { get; set; }

    public DateTime? datFechaBaja { get; set; }

    public string? strUsuarioBaja { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public string? strUsuarioAlta { get; set; }

    public DateTime? datFechaMod { get; set; }

    public string? strUsuarioMod { get; set; }

    public string? strPasswordTPV { get; set; }

    public DateTime? datFechaUltimoLogin { get; set; }

    public DateTime? datFechaUltimoCambioPassword { get; set; }

    public bool? bitForzarCambioPassword { get; set; }

    public string? strEstatus { get; set; }

    public int? intIntentos { get; set; }

    public byte[]? strPassword { get; set; }

    public string? strCorreo { get; set; }

    public string? strRFID { get; set; }

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();

    public virtual ICollection<tblUsuarioIsla> tblUsuarioIslas { get; set; } = new List<tblUsuarioIsla>();
}
