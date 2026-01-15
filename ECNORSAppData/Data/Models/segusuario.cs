using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class segusuario
{
    public string strUsuario { get; set; } = null!;

    public string strPassword { get; set; } = null!;

    public string strNombreCompleto { get; set; } = null!;

    public string? strFolio { get; set; }

    public int? bolDirecto { get; set; }

    public string? strPuerto { get; set; }
}
