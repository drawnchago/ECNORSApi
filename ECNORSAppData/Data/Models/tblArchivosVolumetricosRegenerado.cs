using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblArchivosVolumetricosRegenerado
{
    public string? Nombre { get; set; }

    public string? Nombre_Buscado { get; set; }

    public string? ExisteArchivo { get; set; }

    public string? ExisteBD { get; set; }

    public string? TienesDatos { get; set; }

    public int? Hora { get; set; }
}
