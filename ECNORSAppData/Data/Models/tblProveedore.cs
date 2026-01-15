using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProveedore
{
    public int intProveedor { get; set; }

    public string strNombre { get; set; } = null!;

    public string? strDireccion { get; set; }

    public string? strColonia { get; set; }

    public string? strCiudad { get; set; }

    public string? strEstado { get; set; }

    public string? strCP { get; set; }

    public string? strTelefonos { get; set; }

    public string strFax { get; set; } = null!;

    public string? strRFC { get; set; }

    public bool bitActivo { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public DateTime? datFechaCaptura { get; set; }

    public string? strPCCaptura { get; set; }

    public string? strUsuarioModificacion { get; set; }

    public DateTime? datFechaModificacion { get; set; }

    public string? strPCModificacion { get; set; }
}
