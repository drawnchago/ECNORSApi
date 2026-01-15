using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class PemexTiposArchivo
{
    public short TipoArchivo { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<PemexEnvioArchivo> PemexEnvioArchivos { get; set; } = new List<PemexEnvioArchivo>();
}
